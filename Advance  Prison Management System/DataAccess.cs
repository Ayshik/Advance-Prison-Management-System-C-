using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advance__Prison_Management_System
{
   public class DataAccess
    {

        SqlConnection con;
        public DataAccess()
        {
            con = new SqlConnection(@"Data Source=AYSH-STAR;Initial Catalog=PMS;Integrated Security=True");
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }



        public DataTable Logindg(Login l)
        {

            string query = string.Format("Select * from DG where username= '" + l.Userid + "' and password='" + l.Password + "'");
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter sa = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sa.Fill(dt);
            con.Close();
            return dt;

        }

        public DataTable Loginig(Login l)
        {

            string query = string.Format("Select * from IG where username= '" + l.Userid + "' and password='" + l.Password + "'");
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter sa = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sa.Fill(dt);
            con.Close();
            return dt;

        }


        public DataTable Loginsup(Login l)
        {

            string query = string.Format("Select * from SUP where username= '" + l.Userid + "' and password='" + l.Password + "'");
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter sa = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sa.Fill(dt);
            con.Close();
            return dt;

        }


        public int Createnewcell(Cell u)
        {
            int i = 0;
            string query = "INSERT INTO Cell(cellno,type,status,condition) VALUES ('"+u.Cellno+"','"+u.Celltype+"','Free','New')";
            SqlCommand cmd = new SqlCommand(query, con);

            i = cmd.ExecuteNonQuery();

            return i;

        }

        public DataTable Cellinfo(Cell u)
        {
            string query = string.Format("Select * from Cell");
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter sa = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sa.Fill(dt);
            // con.Close();
            return dt;
        }

        public DataTable Cellsearch(Cell u)
        {
            string query = string.Format("select * from Cell where cellno = '"+u.Cellno+"';");
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter sa = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sa.Fill(dt);
            // con.Close();
            return dt;
        }

        public DataTable LockedCellinfo(Cell u)
        {
            string query = string.Format("Select * from Cell where condition='Locked'");
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter sa = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sa.Fill(dt);
            // con.Close();
            return dt;
        }

        public DataTable LockedCellsearch(Cell u)
        {
            string query = string.Format("select * from Cell where cellno = '" + u.Cellno + "' And  condition = 'Locked';");
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter sa = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sa.Fill(dt);
            // con.Close();
            return dt;
        }

        public DataTable UnLockedCellinfo(Cell u)
        {
            string query = string.Format("Select * from Cell where condition='Unlocked'");
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter sa = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sa.Fill(dt);
            // con.Close();
            return dt;
        }

        public DataTable UnLockedCellsearch(Cell u)
        {
            string query = string.Format("select * from Cell where cellno = '" + u.Cellno + "' And condition = 'Unlocked';");
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter sa = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sa.Fill(dt);
            // con.Close();
            return dt;
        }

        public int CellUnlockone(Cell u)
        {
            int i = 0;
            string query = String.Format("UPDATE Cell SET condition='Unlocked' where sl='{0}'", u.sl);
            SqlCommand cmd = new SqlCommand(query, con);
            i = cmd.ExecuteNonQuery();
            return i;
        }


        public int CellUnlockAll(Cell u)
        {
            int i = 0;
            string query = String.Format("UPDATE cell SET condition='Unlocked' where condition='Locked'");
            SqlCommand cmd = new SqlCommand(query, con);
            i = cmd.ExecuteNonQuery();
            return i;
        }




        public int Celllockone(Cell u)
        {
            int i = 0;
            string query = String.Format("UPDATE Cell SET condition='Locked' where sl='{0}'", u.sl);
            SqlCommand cmd = new SqlCommand(query, con);
            i = cmd.ExecuteNonQuery();
            return i;
        }


        public int CelllockAll(Cell u)
        {
            int i = 0;
            string query = String.Format("UPDATE cell SET condition='Locked' where condition='Unlocked'");
            SqlCommand cmd = new SqlCommand(query, con);
            i = cmd.ExecuteNonQuery();
            return i;
        }




        public DataTable FreeCellinfo(Cell u)
        {
            string query = string.Format("Select * from Cell where status='Free'");
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter sa = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sa.Fill(dt);
            // con.Close();
            return dt;
        }


        public void Addprisoner(Prisoner u)
        {
           
            string query = "INSERT INTO Prisoner(cellno,type,prisoner,crime,caseno,gender,height,status,condition,validity,workstatus,salary) VALUES ('"+u.Cellno+"','"+u.Celltype+"','"+ u.CellPrisoner+"','"+u.Crime+"','"+u.CaseNo+"','"+u.Gender+"','"+u.Height+"','Booked','Locked','Active','Free','0')";
            string query1 = "UPDATE Cell SET prisoner= '"+u.CellPrisoner+ "',crime= '" + u.Crime + "',caseno= '" + u.CaseNo + "',status='Booked',condition='Locked' Where sl='"+u.sl+"'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlCommand cmd1 = new SqlCommand(query1, con);

            cmd.ExecuteNonQuery();
            cmd1.ExecuteNonQuery();
           

        }


        //preson info DG

        public DataTable prisonerinfo(Prisoner u)
        {
            string query = string.Format("Select * from Prisoner where validity='Active'");
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter sa = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sa.Fill(dt);
            // con.Close();
            return dt;
        }

        public DataTable prisonersearch(Prisoner u)
        {
            string query = string.Format("select * from Prisoner where caseno='"+u.CaseNo+"' And validity = 'Active';");
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter sa = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sa.Fill(dt);
            // con.Close();
            return dt;
        }


         public void Releaseprisoner(Prisoner u)
        {
           
            string query = "UPDATE Prisoner SET status='Free',condition='Unlocked',validity='Released',releaseddate='"+DateTime.Now+"' Where sl='" + u.sl + "'";
            string query1 = "UPDATE Cell SET Prisoner= 'Free',crime= 'Free',caseno= 'Free',status='Free',condition='UnLocked' Where cellno='"+u.Cellno+"'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlCommand cmd1 = new SqlCommand(query1, con);

            cmd.ExecuteNonQuery();
            cmd1.ExecuteNonQuery();
           

        }

        public DataTable prisonernamesearch(Prisoner u)
        {
            string query = string.Format("select * from Prisoner where prisoner='" + u.CellPrisoner + "' And validity = 'Active';");
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter sa = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sa.Fill(dt);
            // con.Close();
            return dt;
        }



        public void Addvisiters(Addvisitors u)
        {

            string query = "INSERT INTO Visitors(cellno,type,prisoner,crime,caseno,visitorname,visittime) VALUES ('" + u.Cellno + "','" + u.Celltype + "','" + u.CellPrisoner + "','" + u.Crime + "','" + u.CaseNo + "','" + u.visitorname + "','" +DateTime.Now+ "')";
           
            SqlCommand cmd = new SqlCommand(query, con);
           
            cmd.ExecuteNonQuery();
            


        }

        public DataTable workinfo(Workdetails u)
        {
            string query = string.Format("Select * from Workinfo where status='Active'");
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter sa = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sa.Fill(dt);
            // con.Close();
            return dt;
        }



        public void Addworker(Workdetails u)
        {

            string query = "INSERT INTO Worker(sl,workcode,worktype,prisonerno,prisonername,salarypermonth,issuedate,payment,balance) VALUES ('" + u.worksl + "','" + u.workcode + "','" + u.worktype + "','" + u.prisonerno + "','" + u.prisonername + "','" + u.salary + "','" + DateTime.Now + "','Pending','" + u.balance + "')";
            string query1 = "UPDATE Workinfo SET manboocked='"+u.manbooked+"'Where workcode='"+u.workcode+"'";
            string query2 = "UPDATE Prisoner SET workstatus='Booked'Where sl='"+u.prisonerno+"'";
            SqlCommand cmd = new SqlCommand(query, con);
                SqlCommand cmd2 = new SqlCommand(query1, con);
            SqlCommand cmd3 = new SqlCommand(query2, con);

            cmd.ExecuteNonQuery();
            cmd2.ExecuteNonQuery();
            cmd3.ExecuteNonQuery();



        }
        public DataTable prisonerworkinfo(Prisoner u)
        {
            string query = string.Format("Select * from Prisoner where validity='Active' And workstatus='Free'");
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter sa = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sa.Fill(dt);
            // con.Close();
            return dt;
        }


        public int CreateAccountsup(Signupuser u)
        {
            int i = 0;
            string query = "INSERT INTO SUP(name,gender,phoneno,address,dob,password,securityquestion,securityans) VALUES ('" + u.name + "','" + u.gender + "', '" + u.mobileno + "', '" + u.address + "','" + u.Dob + "','" + u.Password + "','" + u.question + "','" + u.answer + "')";
            SqlCommand cmd = new SqlCommand(query, con);

            i = cmd.ExecuteNonQuery();

            return i;

        }

        public DataTable supfetchid(Signupuser u)
        {
            string query = string.Format("Select sl from SUP where name='{0}' and password='{1}' and securityquestion='{2}' and phoneno='{3}'", u.name, u.Password, u.question, u.mobileno);
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter sa = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sa.Fill(dt);
            //con.Close();
            return dt;
        }



        public int updateuseridsup(Signupuser u)
        {
            int i = 0;
            string query = String.Format("UPDATE SUP SET username='" + u.username + "' where sl='{0}'", u.Userid);
            SqlCommand cmd = new SqlCommand(query, con);
            i = cmd.ExecuteNonQuery();
            return i;
        }




        public DataTable salarypendinginfo(Workdetails u)
        {
            string query = string.Format("Select * from worker where payment='Pending'");
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter sa = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sa.Fill(dt);
            // con.Close();
            return dt;
        }


        public void updatesalarystatus(Workdetails u)
        {

            string query = "UPDATE worker SET payment='Clear'Where prisonerno='" + u.prisonerno + "'";
            string query1 = "UPDATE Prisoner SET salary='" + u.salary + "' Where sl='" + u.prisonerno + "'";
            string query2 = "UPDATE Prisoner SET workstatus='Free'Where sl='" + u.prisonerno + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlCommand cmd1 = new SqlCommand(query1, con);
            SqlCommand cmd3 = new SqlCommand(query2, con);

            cmd.ExecuteNonQuery();
            cmd1.ExecuteNonQuery();
            cmd3.ExecuteNonQuery();



        }




        public DataTable igprofile(Signupuser u)
        {
            string query = string.Format("Select * from IG where username='" + u.username + "'");
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter sa = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sa.Fill(dt);
            // con.Close();
            return dt;
        }


        public int igupdate(Signupuser u)
        {
            int i = 0;
            string query = String.Format("UPDATE IG SET phoneno='" + u.mobileno + "',address='" + u.address + "',password='" + u.Password + "' where username='{0}'", u.username);
            SqlCommand cmd = new SqlCommand(query, con);
            i = cmd.ExecuteNonQuery();
            return i;
        }




        public DataTable iginfo(Signupuser u)
        {
            string query = string.Format("Select * from IG ");
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter sa = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sa.Fill(dt);
            // con.Close();
            return dt;
        }

        public DataTable suprviserinfo(Signupuser u)
        {
            string query = string.Format("Select * from SUP ");
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter sa = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sa.Fill(dt);
            // con.Close();
            return dt;
        }


        public void Addwork(Workdetails u)
        {

            string query = "INSERT INTO Workinfo(workcode,worktype,manpower,manboocked,workrequirement,salarypermonth,issuedate,status) VALUES ('" + u.workcode + "','" + u.worktype + "','" + u.manpower + "','0','" + u.requirement + "','" + u.salary + "','" + DateTime.Now + "','Active')";

            SqlCommand cmd = new SqlCommand(query, con);

            cmd.ExecuteNonQuery();



        }


        public DataTable workinfosearch(Workdetails u)
        {
            string query = string.Format("select * from Workinfo where worktype like '" + u.worktype + "%';");
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter sa = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sa.Fill(dt);
            // con.Close();
            return dt;
        }


        public void updateworkstatus(Workdetails u)
        {

            string query = "UPDATE Workinfo SET status='Inactive' Where workcode='" + u.workcode + "'";
           
            SqlCommand cmd = new SqlCommand(query, con);
           

            cmd.ExecuteNonQuery();
           


        }

        public int CreateAccountIG(Signupuser u)
        {
            int i = 0;
            string query = "INSERT INTO IG(name,gender,phoneno,address,dob,password,securityquestion,securityans) VALUES ('" + u.name + "','" + u.gender + "', '" + u.mobileno + "', '" + u.address + "','" + u.Dob + "','" + u.Password + "','" + u.question + "','" + u.answer + "')";
            SqlCommand cmd = new SqlCommand(query, con);

            i = cmd.ExecuteNonQuery();

            return i;

        }

        public DataTable IGfetchid(Signupuser u)
        {
            string query = string.Format("Select sl from IG where name='{0}' and password='{1}' and securityquestion='{2}' and phoneno='{3}'", u.name, u.Password, u.question, u.mobileno);
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter sa = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sa.Fill(dt);
            //con.Close();
            return dt;
        }
        public int updateuseridIG(Signupuser u)
        {
            int i = 0;
            string query = String.Format("UPDATE IG SET username='" + u.username + "' where sl='{0}'", u.Userid);
            SqlCommand cmd = new SqlCommand(query, con);
            i = cmd.ExecuteNonQuery();
            return i;
        }

        public int DeleteIG(Signupuser u)
        {
            int i = 0;
            string query = String.Format("Delete from IG where username='" + u.username + "'");
            SqlCommand cmd = new SqlCommand(query, con);
            i = cmd.ExecuteNonQuery();
            return i;
        }

        public int UpdateAnouncement(Anounce u)
        {
            int i = 0;
            string query = String.Format("UPDATE Anouncement SET text='" + u.text + "' where sl='1'");
            SqlCommand cmd = new SqlCommand(query, con);
            i = cmd.ExecuteNonQuery();
            return i;
        }


        public DataTable Anouncement(Anounce u)
        {
            string query = string.Format("Select text from Anouncement where sl='1' ");
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter sa = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sa.Fill(dt);
            // con.Close();
            return dt;
        }

        public DataTable forgetdg(Login l)
        {

            string query = string.Format("Select * from DG where username= '" + l.Userid + "'");
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter sa = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sa.Fill(dt);
            con.Close();
            return dt;

        }

        public DataTable forgetig(Login l)
        {

            string query = string.Format("Select * from IG where username= '" + l.Userid + "'");
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter sa = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sa.Fill(dt);
            con.Close();
            return dt;

        }


        public DataTable forgetsup(Login l)
        {

            string query = string.Format("Select * from SUP where username= '" + l.Userid + "'");
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter sa = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sa.Fill(dt);
            con.Close();
            return dt;

        }

    }
}
