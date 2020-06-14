using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;
using System.Windows.Forms;

namespace Shopbowl
{
    public class DataAccess
    { 
        public List<Customers> GetCustomers(string lastName)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("BowlingStormAccessories")))
            {
                var output = connection.Query<Customers>("dbo.GetByLastName @LastName", new { LastName = lastName }).ToList();
                //var output = connection.Query<Customers>($"Select * From Customers Where Lname = '{lastName}'").ToList();
                return output;
            }
        }

        public void InsertCustomers(string fistName, string lastName , string threeName, string addres, string cityName, string phoneNumber, string dataInSystem )
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("BowlingStormAccessories")))
            {
                try
                {
                    List<Customers> customers = new List<Customers>();

                    customers.Add(new Customers { Fname = fistName, Lname = lastName, Mname = threeName, Address = addres, City = cityName, Phone = phoneNumber, DataInSystem = dataInSystem });

                    connection.Execute("dbo.InsertCustomers @FName, @LName, @MName, @Address, @City, @Phone, @DataInSystem ", customers);
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Неправильний формат!\nФормат має відповідати цьому:(000)1122333");
                }
                // Customers newCustomers = new Customers {Fname = fistName, Lname = lastName, Mname = threeName, Address = addres, City = cityName, Phone = phoneNumber};



            }
        }

        public  List<Emploees> GetEmploees(string lastNameE)
        {
           using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("BowlingStormAccessories")))
            {
                var output = connection.Query<Emploees>("dbo.GetByLastNameEmploees @LastName", new { LastName = lastNameE }).ToList();
                return output;
            }                                                                                                                                                                       
        }
        //public void Search(string lastName)
        //{
        //    //using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("BowlingStormAccessories")))
        //    //{
        //    //    connection.Execute("", new { LastName = lastName});
        //    //}
        //}

        public List<Maker> GetMaker()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("BowlingStormAccessories")))
            {
                var output = connection.Query<Maker>("dbo.GetAllInfoMaker", new { }).ToList();
                return output;
            }
        }

        public List<TypeProduct> GetTypeProduct()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("BowlingStormAccessories")))
            {
                var output = connection.Query<TypeProduct>("dbo.GetAllInfoTypeProduct", new { }).ToList();
                return output;
            }
        }

        public List<Descript> GetDescript()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("BowlingStormAccessories")))
            {
                var output = connection.Query<Descript>("dbo.GetAllInfoDescription", new { }).ToList();
                return output;
            }
        }

        public void InsertEmploees(string firstnameE, string lastNameE, string threeNameE, string post, string salary, string priorSalary)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("BowlingStormAccessories")))
            {
                List<Emploees> emploees = new List<Emploees>();

                emploees.Add(new Emploees { Fname = firstnameE, Lname = lastNameE, Mname = threeNameE, Post = post, Salary = salary, PriorSalary = priorSalary });

                connection.Execute("dbo.InsertEmployees @Fname, @LName, @MName, @Post, @Salary, @PriorSalary", emploees);
            }
        }
        public void DeleteEmploees(string id)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("BowlingStormAccessories")))
            {

                List<Emploees> emploees = new List<Emploees>();
                emploees.Add(new Emploees { ID = Convert.ToInt32(id) });
                connection.Execute("dbo.DeleteEmploees @ID", emploees);
            }
        }
        public void InsertMaker(string companyName, string country)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("BowlingStormAccessories")))
            {
                List<Maker> makers = new List<Maker>();
                makers.Add(new Maker { CompanyName = companyName, Country = country });
                connection.Execute("dbo.InsertMaker @CompanyName, @Country", makers);
            }
        }

        public void InsertTypeProduct(string typeProd)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("BowlingStormAccessories")))
            {
                List<TypeProduct> typeproducts = new List<TypeProduct>();
                typeproducts.Add(new TypeProduct{ Type = typeProd });
                connection.Execute("dbo.InsertTypeProduct @Type", typeproducts);

            }
        }
        public void InsertDescript(string details)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("BowlingStormAccessories")))
            {
                List<Descript> descripts = new List<Descript>();
                descripts.Add(new Descript { Details = details });
                connection.Execute("dbo.InsertDescript @Details", descripts);
            }
        }
        public List<Goods> GetGoods(string namegoods)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("BowlingStormAccessories")))
            {
                var output = connection.Query<Goods>("dbo.GetGoods @Name", new {Name = namegoods}).ToList();
                return output;
            }
        }
        public void InsertGoods(string name, string idtype, string iddescript, string idmaker, string countgoods, string pricedolar)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("BowlingStormAccessories")))
            {
                List<Goods> goods = new List<Goods>();
                goods.Add(new Goods { Name = name, Type = idtype, Details = iddescript, CompanyName = idmaker, StatusView = countgoods, price = pricedolar});
                connection.Execute("dbo.InsertProducts @Name, @Type, @Details, @CompanyName, @StatusView, @price", goods);

            }
        }
        public void UpdateGoods(string idnumber, string name, string idtype, string iddescript, string idmaker, string countgoods, string pricedolar)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("BowlingStormAccessories")))
            {
                List<Goods> goods = new List<Goods>();
                goods.Add(new Goods { Id = idnumber, Name = name, Type = idtype, Details = iddescript, CompanyName = idmaker, StatusView = countgoods, price = pricedolar });
                connection.Execute("dbo.UpdateProducts @id, @Name, @Type, @Details, @CompanyName, @StatusView, @price", goods);

            }
        }
        public void AddOrders1(string id, string idcustm, string idemploee, string dataodrer, string datasplit)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("BowlingStormAccessories")))
            {
                List<Order> orders = new List<Order>();

                orders.Add(new Order { ID = id, IDCustm = idcustm, IDEmploee = idemploee, DataOrder = dataodrer, DataSplit = datasplit });

                connection.Execute("dbo.InsertOrders_1   @ID, @IDCustm, @IDEmploee, @DataOrder, @DataSplit", orders);
            }
        }
        public void AddOrders2(string id, string idcustm, string idemploee)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("BowlingStormAccessories")))
            {
                List<OrdersTwo> ordertwo = new List<OrdersTwo>();

                ordertwo.Add(new OrdersTwo { IdOrders = id, IDgoods = idcustm, CountGoods = idemploee });

                connection.Execute("dbo.InsertOrders_2   @IdOrders, @IDgoods, @CountGoods", ordertwo);
            }
        }



    }
}
