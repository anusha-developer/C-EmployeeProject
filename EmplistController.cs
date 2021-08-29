using Employee.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Employee.Controllers
{
    class program

    {
        static void Main(string[] args)
        { 

        [HttpGet]
        [Route("api/student")]

        public List<std> Getstudent()
            { 

             Student theStudent= new Student();
            List<Student> st = new List<Student>();
                Student s1 = new Student();
            SqlConnection con = new SqlConnection("data source=.;database=master;integrated security=SSPI");
            con.Open();
            string query = "select * from student";
            SqlCommand cm = new SqlCommand(query, con);
            SqlDataReader dr = cm.ExecuteReader();


            while (dr.Read())
            {
                s1 = new Student();
                s1.stdid = Convert.ToInt32(dr["stdid"]);
                s1.name = dr["name"].ToString();
                s1.course = dr["course"].ToString();
                s1.location = dr["location"].ToString();
                    //s1.mobileno = dr["mobileno"].ToString();
                    //s1.patientname = dr["patientname"].ToString();
                    //s1.speciality = dr["speciality"].ToString();
                    //s1.proce = dr["proce"].ToString();
                    st.Add(s1);
            }
            con.Close();



                return st;

        }


        

        //[HttpPost]
        // [Route("api/postEmpdet")]

        //public Empdet insertEmpdet([FromBody] Empdet em)
        //{
        //  Empdet s1 = new Empdet();
        //SqlConnection con = new SqlConnection("data source=.;database=master;integrated security=SSPI");
        //  //con.Open();
        //string query = "  insert into * from Empdet " +
        //  "(Empid,EmplName,casenumber,Referenceid,patient,patientname,speciality,proce)" +
        //" Values(" + em.Empid + "," + em.EmplName + "," + em.casenumber + "," + em.Referenceid + " , " +
        //"" + em.patient + "," + em.patientname + " " + em.speciality + "," + em.proce + ")";
        //SqlCommand cm = new SqlCommand(query, con);
        //SqlDataReader dr = cm.ExecuteReader();
        //    con.Close();
        //}



        // GET: api/Emplist/5    

       /* [HttpGet]
        [Route("api/GetInvesDetails")]
        public List<Investdetcs> GetInvestdetcs()
        {
            List<Investdetcs> emp = new List<Investdetcs>();
            Investdetcs l1 = new Investdetcs();
            SqlConnection con = new SqlConnection("data source=.;database=master;integrated security=SSPI");
            con.Open();
            //SqlCommand cm = new SqlCommand("select * from InvesDetails", con);
            String Query = "select * from InvesDetails";
            SqlCommand cm = new SqlCommand(Query, con);
            SqlDataReader dr = cm.ExecuteReader();
            while (dr.Read())
            {
                l1.sno = Convert.ToInt32(dr["sno"]);
                l1.investidate = dr["investidate"].ToString();
                l1.depart = dr["depart"].ToString();
                l1.nameofinvesti = dr["nameofinvesti"].ToString();
                l1.cost = Convert.ToInt32(dr["cost"]);
                emp.Add(l1);



            }

            con.Close();


            return emp;


        }

        //[HttpPost]
        //[Route("api/postInvestdetcs")]
//        public Investdetcs insertInvestdetcs([FromBody] Investdetcs I)

//        {

  //          Investdetcs l1 = new Investdetcs();
    //        SqlConnection con = new SqlConnection("data source=.;database=master;integrated security=SSPI");
      //      con.Open();
            //SqlCommand cm = new SqlCommand("select * from InvesDetails", con);
        //    String Query = "insert into InvesDetails " + "(sno int ,investidate varchar(10),depart varchar(20),nameofinvesti varchar(10),cost int ) " +
          //                 "values(" + I.sno + "," + I.investidate + "," + I.depart + "," + I.nameofinvesti + "," + I.cost + ")";
            //SqlCommand cm = new SqlCommand(Query, con);
            //SqlDataReader dr = cm.ExecuteReader();

        //}*/




            public string Get(int id)
            {
                return "value";
            }

            // POST: api/Emplist
            public void Post([FromBody] string value)
            {
            }

            // PUT: api/Emplist/5
            public void Put(int id, [FromBody] string value)
            {
            }

            // DELETE: api/Emplist/5
            public void Delete(int id)
            {
            }
        }

    }


           
        















