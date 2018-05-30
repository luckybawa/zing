using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
namespace Educom
{
    public interface intstu
    {
        Int32 stucod
        {
            get;
            set;
        }
        String stunam
        {
            get;
            set;
        }
        String stucol
        {
            get;
            set;
        }
        String sturolno
        {
            get;
            set;
        }
        DateTime stutrgstrdat
        {
            get;
            set;
        }
        DateTime stutrgenddat
        {
            get;
            set;
        }
        String stupic
        {
            get;
            set;
        }
        String stuusrnam
        {
            get;
            set;
        }
        String stupwd
        {
            get;
            set;
        }
    }
    public class clsstuprp : intstu
    {
        private Int32 pstucod;
        private String pstunam, pstucol, psturolno, pstupic, pstuusrnam, pstupwd;
        private DateTime pstutrgstrdat, pstutrgenddat;
        public int stucod
        {
            get
            {
                return pstucod;
            }
            set
            {
                pstucod = value;
            }
        }

        public string stunam
        {
            get
            {
                return pstunam;
            }
            set
            {
                pstunam = value;
            }
        }

        public string stucol
        {
            get
            {
                return pstucol;
            }
            set
            {
                pstucol = value;
            }
        }

        public string sturolno
        {
            get
            {
                return psturolno;
            }
            set
            {
                psturolno = value;
            }
        }

        public DateTime stutrgstrdat
        {
            get
            {
                return pstutrgstrdat;
            }
            set
            {
                pstutrgstrdat = value;
            }
        }

        public DateTime stutrgenddat
        {
            get
            {
                return pstutrgenddat;
            }
            set
            {
                pstutrgenddat = value;
            }
        }

        public string stupic
        {
            get
            {
                return pstupic;
            }
            set
            {
                pstupic = value;
            }
        }

        public string stuusrnam
        {
            get
            {
                return pstuusrnam;
            }
            set
            {
                pstuusrnam = value;
            }
        }

        public string stupwd
        {
            get
            {
                return pstupwd;
            }
            set
            {
                pstupwd = value;
            }
        }
    }
    public class clsstu : clscon
    {
        public Int32 logstu(String usrnam, String pwd)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand("logstu", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@stuusrnam", SqlDbType.VarChar, 50).Value = usrnam;
            cmd.Parameters.Add("@stupwd", SqlDbType.VarChar, 50).Value = pwd;
            cmd.Parameters.Add("@r", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
            cmd.ExecuteNonQuery();
            Int32 a = Convert.ToInt32(cmd.Parameters["@r"].Value);
            cmd.Dispose();
            con.Close();
            return a;
        }
        public List<clsstuprp> find_rec(Int32 stucod)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("fndstu", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@stucod", SqlDbType.Int).Value = stucod;
            SqlDataReader dr = cmd.ExecuteReader();
            List<clsstuprp> obj = new List<clsstuprp>();
            if (dr.HasRows)
            {
                dr.Read();
                clsstuprp k = new clsstuprp();
                k.stucod = Convert.ToInt32(dr[0]);
                k.stunam = dr[1].ToString();
                k.stucol = dr[2].ToString();
                k.sturolno = dr[3].ToString();
                k.stutrgstrdat = Convert.ToDateTime(dr[4]);
                k.stutrgenddat = Convert.ToDateTime(dr[5]);
                k.stupic = dr[6].ToString();
                k.stuusrnam = dr[7].ToString();
                k.stupwd = dr[8].ToString();
                obj.Add(k);
            }
            dr.Close();
            cmd.Dispose();
            con.Close();
            return obj;
        }
        public Int32 save_rec(clsstuprp p)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand("insstu", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@stunam", SqlDbType.VarChar, 50).Value = p.stunam;
            cmd.Parameters.Add("@stucol", SqlDbType.VarChar, 50).Value = p.stucol;
            cmd.Parameters.Add("@sturolno", SqlDbType.VarChar, 50).Value = p.sturolno;
            cmd.Parameters.Add("@stutrgstrdat", SqlDbType.DateTime).Value = p.stutrgstrdat;
            cmd.Parameters.Add("@stutrgenddat", SqlDbType.DateTime).Value = p.stutrgenddat;
            cmd.Parameters.Add("@stupic", SqlDbType.VarChar, 50).Value = p.stupic;
            cmd.Parameters.Add("@stuusrnam", SqlDbType.VarChar, 50).Value = p.stuusrnam;
            cmd.Parameters.Add("@stupwd", SqlDbType.VarChar, 50).Value = p.stupwd;
            cmd.Parameters.Add("@r", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
            cmd.ExecuteNonQuery();
            Int32 a = Convert.ToInt32(cmd.Parameters["@r"].Value);
            cmd.Dispose();
            con.Close();
            return a;
        }

    }

    public interface intusr
    {
        Int32 usrcod
        {
            get;
            set;
        }
        String usreml
        {
            get;
            set;
        }
        String usrpwd
        {
            get;
            set;
        }
        DateTime usrdat
        {
            get;
            set;
        }
        Char usrrol
        {
            get;
            set;
        }
    }
    public interface intprf
    {
        Int32 prfcod
        {
            get;
            set;
        }
        String prffstnam
        {
            get;
            set;
        }
        String prflstnam
        {
            get;
            set;
        }
        String prfdsc
        {
            get;
            set;
        }
        String prfpic
        {
            get;
            set;
        }
    }
    public interface intcat
    {
        Int32 catcod
        {
            get;
            set;
        }
        String catnam
        {
            get;
            set;
        }
        String catpic
        {
            get;
            set;
        }

    }
    public interface intlescol
    {
        Int32 lescolcod
        {
            get;
            set;
        }
        Int32 lescolcatcod
        {
            get;
            set;
        }
        String lescoltit
        {
            get;
            set;
        }
        String lescoldsc
        {
            get;
            set;
        }
        String lescolpic
        {
            get;
            set;
        }
        Int32 lescolusrcod
        {
            get;
            set;
        }
        DateTime lescoldat
        {
            get;
            set;
        }
        float lescolcst
        {
            get;
            set;
        }
        String lescolsec
        {
            get;
            set;
        }
        char lescolpubsts
        {
            get;
            set;
        }
    }
    public interface intles
    {
        Int32 lescod
        {
            get;
            set;
        }
        Int32 leslescolcod
        {
            get;
            set;
        }
        String lestit
        {
            get;
            set;
        }
        String lesdsc
        {
            get;
            set;
        }
        String lestim
        {
            get;
            set;
        }
        String lesfil
        {
            get;
            set;
        }
        Char lesord
        {
            get;
            set;
        }
    }
    public interface intlesatt
    {
        Int32 lesattcod
        {
            get;
            set;
        }
        Int32 lesattlescod
        {
            get;
            set;
        }
        String lesattnam
        {
            get;
            set;
        }
        String lesattfil
        {
            get;
            set;
        }
    }
    public interface intlesexr
    {
        Int32 lesexrcod
        {
            get;
            set;
        }
        String lesexrtit
        {
            get;
            set;
        }
        Int32 lesexrlescod
        {
            get;
            set;
        }
    }
    public interface intqst
    {
        Int32 qstcod
        {
            get;
            set;
        }
        Int32 qstlecexrcod
        {
            get;
            set;
        }
        String qstdsc
        {
            get;
            set;
        }
        Int32 qstord
        {
            get;
            set;
        }
    }
    public interface intopt
    {
        Int32 optcod
        {
            get;
            set;
        }
        Int32 optqstcod
        {
            get;
            set;
        }
        String optdsc
        {
            get;
            set;
        }
        Char optsts
        {
            get;
            set;
        }
    }
    public interface intenr
    {
        Int32 enrcod
        {
            get;
            set;
        }
        DateTime enrdat
        {
            get;
            set;
        }
        Int32 enrusrcod
        {
            get;
            set;
        }
        Int32 enrlescolcod
        {
            get;
            set;
        }
    }
    public interface intdis
    {
        Int32 discod
        {
            get;
            set;
        }
        Int32 disleccod
        {
            get;
            set;
        }
        Int32 disusrcod
        {
            get;
            set;
        }
        String distit
        {
            get;
            set;
        }
        String disdsc
        {
            get;
            set;
        }
        String disrep
        {
            get;
            set;
        }
        DateTime disdat
        {
            get;
            set;
        }
    }

    public class clsusrprp : intusr
    {
        private Int32 prpusrcod;
        private String prpusreml, prpusrpwd;
        private DateTime prpusrdat;
        private Char prpusrrol;

        public int usrcod
        {
            get
            {
                return prpusrcod;
            }
            set
            {
                prpusrcod = value;
            }
        }

        public string usreml
        {
            get
            {
                return prpusreml;
            }
            set
            {
                prpusreml = value;
            }
        }

        public string usrpwd
        {
            get
            {
                return prpusrpwd;
            }
            set
            {
                prpusrpwd = value;
            }
        }

        public DateTime usrdat
        {
            get
            {
                return prpusrdat;
            }
            set
            {
                prpusrdat = value;
            }
        }

        public char usrrol
        {
            get
            {
                return prpusrrol;
            }
            set
            {
                prpusrrol = value;
            }
        }
    }
    public class clsprfprp : intprf
    {
        private Int32 prpprfcod;
        private String prpfstnam, prplstnam, prpprfdsc, prpprfpic;


        public int prfcod
        {
            get
            {
                return prpprfcod;
            }
            set
            {
                prpprfcod = value;
            }
        }

        public string prffstnam
        {
            get
            {
                return prpfstnam;
            }
            set
            {
                prpfstnam = value;
            }
        }

        public string prflstnam
        {
            get
            {
                return prplstnam;
            }
            set
            {
                prplstnam = value;
            }
        }

        public string prfdsc
        {
            get
            {
                return prpprfdsc;
            }
            set
            {
                prpprfdsc = value;
            }
        }

        public string prfpic
        {
            get
            {
                return prpprfpic;
            }
            set
            {
                prpprfpic = value;
            }
        }
    }
    public class clscatprp : intcat
    {
        private Int32 prpcatcod;
        private String prpcatnam, prpcatpic;

        public int catcod
        {
            get
            {
                return prpcatcod;
            }
            set
            {
                prpcatcod = value;
            }
        }

        public string catnam
        {
            get
            {
                return prpcatnam;
            }
            set
            {
                prpcatnam = value;
            }
        }

        public string catpic
        {
            get
            {
                return prpcatpic;
            }
            set
            {
                prpcatpic = value;
            }
        }
    }
    public class clslescolprp : intlescol
    {
        private Int32 prplescolcod, prplescolcatcod, prpcolusrcod;
        private String prplescoltit, prpcoldsc, prplescolpic, prplescolsec;
        private DateTime prplescoldat;
        private float prplescolcst;
        private Char prplescolpubsts;

        public int lescolcod
        {
            get
            {
                return prplescolcod;
            }
            set
            {
                prplescolcod = value;
            }
        }

        public int lescolcatcod
        {
            get
            {
                return prplescolcatcod;
            }
            set
            {
                prplescolcatcod = value;
            }
        }

        public string lescoltit
        {
            get
            {
                return prplescoltit;
            }
            set
            {
                prplescoltit = value;
            }
        }

        public string lescoldsc
        {
            get
            {
                return prpcoldsc;
            }
            set
            {
                prpcoldsc = value;
            }
        }

        public string lescolpic
        {
            get
            {
                return prplescolpic;
            }
            set
            {
                prplescolpic = value;
            }
        }

        public int lescolusrcod
        {
            get
            {
                return prpcolusrcod;
            }
            set
            {
                prpcolusrcod = value;
            }
        }

        public DateTime lescoldat
        {
            get
            {
                return prplescoldat;
            }
            set
            {
                prplescoldat = value;
            }
        }

        public float lescolcst
        {
            get
            {
                return prplescolcst;
            }
            set
            {
                prplescolcst = value;
            }
        }

        public string lescolsec
        {
            get
            {
                return prplescolsec;
            }
            set
            {
                prplescolsec = value;
            }
        }

        public char lescolpubsts
        {
            get
            {
                return prplescolpubsts;
            }
            set
            {
                prplescolpubsts = value;
            }
        }
    }
    public class clslesprp : intles
    {
        private Int32 prplescod, prpleslescolcod;
        private String prplestit, prplesdsc, prplestim, prplesfil;
        private Char prplesord;
        public int lescod
        {
            get
            {
                return prplescod;
            }
            set
            {
                prplescod = value;
            }
        }

        public int leslescolcod
        {
            get
            {
                return prpleslescolcod;
            }
            set
            {
                prpleslescolcod = value;
            }
        }

        public string lestit
        {
            get
            {
                return prplestit;
            }
            set
            {
                prplestit = value;
            }
        }

        public string lesdsc
        {
            get
            {
                return prplesdsc;
            }
            set
            {
                prplesdsc = value;
            }
        }

        public string lestim
        {
            get
            {
                return prplestim;
            }
            set
            {
                prplestim = value;
            }
        }

        public string lesfil
        {
            get
            {
                return prplesfil;
            }
            set
            {
                prplesfil = value;
            }
        }

        public char lesord
        {
            get
            {
                return prplesord;
            }
            set
            {
                prplesord = value;
            }
        }
    }
    public class clslesattprp : intlesatt
    {
        private Int32 prplesattcod, prplesattlescod;
        private String prplesattnam, prplesattfil;

        public int lesattcod
        {
            get
            {
                return prplesattcod;
            }
            set
            {
                prplesattcod = value;
            }
        }

        public int lesattlescod
        {
            get
            {
                return prplesattlescod;
            }
            set
            {
                prplesattlescod = value;
            }
        }

        public string lesattnam
        {
            get
            {
                return prplesattnam;
            }
            set
            {
                prplesattnam = value;
            }
        }

        public string lesattfil
        {
            get
            {
                return prplesattfil;
            }
            set
            {
                prplesattfil = value;
            }
        }
    }
    public class clslesexrprp : intlesexr
    {
        private Int32 prplesexrcod, prplesexrlescod;
        private String prplexrtit;

        public int lesexrcod
        {
            get
            {
                return prplesexrcod;
            }
            set
            {
                prplesexrcod = value;
            }
        }

        public string lesexrtit
        {
            get
            {
                return prplexrtit;
            }
            set
            {
                prplexrtit = value;
            }
        }

        public int lesexrlescod
        {
            get
            {
                return prplesexrlescod;
            }
            set
            {
                prplesexrlescod = value;
            }
        }
    }
    public class clsqstprp : intqst
    {
        private Int32 prpqstcod, prpqstlesexrcod, prpqstord;
        private String prpqstdsc;

        public int qstcod
        {
            get
            {
                return prpqstcod;
            }
            set
            {
                prpqstcod = value;
            }
        }

        public int qstlecexrcod
        {
            get
            {
                return prpqstlesexrcod;
            }
            set
            {
                prpqstlesexrcod = value;
            }
        }

        public string qstdsc
        {
            get
            {
                return prpqstdsc;
            }
            set
            {
                prpqstdsc = value;
            }
        }

        public int qstord
        {
            get
            {
                return prpqstord;
            }
            set
            {
                prpqstord = value;
            }
        }
    }
    public class clsoptprp : intopt
    {
        private Int32 prpoptcod, prpoptqstcod;
        private String prpoptdsc;
        private Char prpoptsts;

        public int optcod
        {
            get
            {
                return prpoptcod;
            }
            set
            {
                prpoptcod = value;
            }
        }

        public int optqstcod
        {
            get
            {
                return prpoptqstcod;
            }
            set
            {
                prpoptqstcod = value;
            }
        }

        public string optdsc
        {
            get
            {
                return prpoptdsc;
            }
            set
            {
                prpoptdsc = value;
            }
        }

        public char optsts
        {
            get
            {
                return prpoptsts;
            }
            set
            {
                prpoptsts = value;
            }
        }
    }
    public class clsenrprp : intenr
    {
        private Int32 prpenrcod, prpenrusrcod, prpenrlescolcod;
        private DateTime prpenrdat;

        public int enrcod
        {
            get
            {
                return prpenrcod;
            }
            set
            {
                prpenrcod = value;
            }
        }

        public DateTime enrdat
        {
            get
            {
                return prpenrdat;
            }
            set
            {
                prpenrdat = value;
            }
        }

        public int enrusrcod
        {
            get
            {
                return prpenrusrcod;
            }
            set
            {
                prpenrusrcod = value;
            }
        }

        public int enrlescolcod
        {
            get
            {
                return prpenrlescolcod;
            }
            set
            {
                prpenrlescolcod = value;
            }
        }
    }
    public class clsdisprp : intdis
    {
        private Int32 prpdiscod, prpdisleccod, prpdisusrcod;
        private String prpdistit, prpdisdsc, prpdisrep;
        private DateTime prpdisdat;

        public int discod
        {
            get
            {
                return prpdiscod;
            }
            set
            {
                prpdiscod = value;
            }
        }

        public int disleccod
        {
            get
            {
                return prpdisleccod;
            }
            set
            {
                prpdisleccod = value;
            }
        }

        public int disusrcod
        {
            get
            {
                return prpdisusrcod;
            }
            set
            {
                prpdisusrcod = value;
            }
        }

        public string distit
        {
            get
            {
                return prpdistit;
            }
            set
            {
                prpdistit = value;
            }
        }

        public string disdsc
        {
            get
            {
                return prpdisdsc;
            }
            set
            {
                prpdisdsc = value;
            }
        }

        public string disrep
        {
            get
            {
                return prpdisrep;
            }
            set
            {
                prpdisrep = value;
            }
        }

        public DateTime disdat
        {
            get
            {
                return prpdisdat;
            }
            set
            {
                prpdisdat = value;
            }
        }
    }

    public abstract class clscon
    {
        protected SqlConnection con = new SqlConnection();
        public clscon()
        {
            con.ConnectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
        }
    }

    public class clsusr : clscon
    {
        public Int32 chgpwd(Int32 usrcod, String oldpwd, String newpwd)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand("chgpwd", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@usrcod", SqlDbType.Int).Value = usrcod;
   cmd.Parameters.Add("@oldpwd", SqlDbType.VarChar, 50).Value = oldpwd;
   cmd.Parameters.Add("@newpwd", SqlDbType.VarChar, 50).Value = newpwd;
   cmd.Parameters.Add("@ret", SqlDbType.Int).Direction = ParameterDirection
                                     .ReturnValue;
   cmd.ExecuteNonQuery();
   Int32 a = Convert.ToInt32(cmd.Parameters["@ret"].Value);
   cmd.Dispose();
   con.Close();
   return a;
        }

        public Int32 logincheck(String eml, String pwd, out char rol)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand("logincheck", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@eml", SqlDbType.VarChar, 50).Value = eml;
            cmd.Parameters.Add("@pwd", SqlDbType.VarChar, 50).Value = pwd;
         cmd.Parameters.Add("@cod", SqlDbType.Int).Direction =
                ParameterDirection.Output;
         cmd.Parameters.Add("@rol", SqlDbType.Char, 1).Direction =
             ParameterDirection.Output;
         cmd.ExecuteNonQuery();
         Int32 a = Convert.ToInt32(cmd.Parameters["@cod"].Value);
         rol = Convert.ToChar(cmd.Parameters["@rol"].Value);
         cmd.Dispose();
         con.Close();
         return a;
        }

        public void save_rec(clsusrprp prp)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("insuser", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@usreml", SqlDbType.VarChar, 50).Value = prp.usreml;
            cmd.Parameters.Add("@usrpwd", SqlDbType.VarChar, 50).Value = prp.usrpwd;
            cmd.Parameters.Add("@usrdat", SqlDbType.DateTime).Value = prp.usrdat;
            cmd.Parameters.Add("@usrrol", SqlDbType.Char, 1).Value = prp.usrrol;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
        public void update_rec(clsusrprp prp)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("upduser", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@usrcod", SqlDbType.Int).Value = prp.usrcod;
            cmd.Parameters.Add("@usreml", SqlDbType.VarChar, 50).Value = prp.usreml;
            cmd.Parameters.Add("@usrpwd", SqlDbType.VarChar, 50).Value = prp.usrpwd;
            cmd.Parameters.Add("@usrdat", SqlDbType.DateTime).Value = prp.usrdat;
            cmd.Parameters.Add("@usrrol", SqlDbType.Char, 1).Value = prp.usrrol;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
        public void delete_rec(clsusrprp prp)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("deluser", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@usrcod", SqlDbType.Int).Value = prp.usrcod;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
        public List<clsusrprp> disp_rec()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("dspuser", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader dr = cmd.ExecuteReader();
            List<clsusrprp> obj = new List<clsusrprp>();
            while (dr.Read())
            {
                clsusrprp k = new clsusrprp();
                k.usrcod = Convert.ToInt32(dr[0]);
                k.usreml = dr[1].ToString();
                k.usrpwd = dr[2].ToString();
                k.usrdat = Convert.ToDateTime(dr[3]);
                k.usrrol = Convert.ToChar(dr[4]);
                obj.Add(k);
            }
            dr.Close();
            cmd.Dispose();
            return obj;
        }
        public List<clsusrprp> find_rec(Int32 usrcod)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("fnduser", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@usrcod", SqlDbType.Int).Value = usrcod;
            SqlDataReader dr = cmd.ExecuteReader();
            List<clsusrprp> obj = new List<clsusrprp>();
            if (dr.HasRows)
            {
                dr.Read();
                clsusrprp k = new clsusrprp();
                k.usrcod = Convert.ToInt32(dr[0]);
                k.usreml = dr[1].ToString();
                k.usrpwd = dr[2].ToString();
                k.usrdat = Convert.ToDateTime(dr[3]);
                k.usrrol = Convert.ToChar(dr[4]);
                obj.Add(k);
            }
            dr.Close();
            cmd.Dispose();
            con.Close();
            return obj;

        }
    }
    public class clsprf : clscon
    {
        public void save_rec(clsprfprp prp)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("insprf", con);
            cmd.CommandType = CommandType.StoredProcedure;
   cmd.Parameters.Add("@prfcod", SqlDbType.Int).Value = prp.prfcod;
            cmd.Parameters.Add("@prffstnam", SqlDbType.VarChar, 50).Value = prp.prffstnam;
            cmd.Parameters.Add("@prflstnam", SqlDbType.VarChar, 50).Value = prp.prflstnam;
            cmd.Parameters.Add("@prfdsc", SqlDbType.NVarChar, 1000).Value = prp.prfdsc;
            cmd.Parameters.Add("@prfpic", SqlDbType.VarChar, 50).Value = prp.prfpic;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
        public void update_rec(clsprfprp prp)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("updprf", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@prfcod", SqlDbType.Int).Value = prp.prfcod;
            cmd.Parameters.Add("@prffstnam", SqlDbType.VarChar, 50).Value = prp.prffstnam;
            cmd.Parameters.Add("@prflstnam", SqlDbType.VarChar, 50).Value = prp.prflstnam;
            cmd.Parameters.Add("@prfdsc", SqlDbType.NVarChar, 1000).Value = prp.prfdsc;
            cmd.Parameters.Add("@prfpic", SqlDbType.VarChar, 50).Value = prp.prfpic;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
        public void delete_rec(clsprfprp prp)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("delprf", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@prfcod", SqlDbType.Int).Value = prp.prfcod;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
        public List<clsprfprp> disp_rec()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("dspprf", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader dr = cmd.ExecuteReader();
            List<clsprfprp> obj = new List<clsprfprp>();
            while (dr.Read())
            {
                clsprfprp k = new clsprfprp();
                k.prfcod = Convert.ToInt32(dr[0]);
                k.prffstnam = dr[1].ToString();
                k.prflstnam = dr[2].ToString();
                k.prfdsc = Convert.ToString(dr[3]);
                k.prfpic = dr[4].ToString();
                obj.Add(k);
            }
            dr.Close();
            cmd.Dispose();
            return obj;
        }
        public List<clsprfprp> find_rec(Int32 prfcod)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("fndprf", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@prfcod", SqlDbType.Int).Value = prfcod;
            SqlDataReader dr = cmd.ExecuteReader();
            List<clsprfprp> obj = new List<clsprfprp>();
            if (dr.HasRows)
            {
                dr.Read();
                clsprfprp k = new clsprfprp();
                k.prfcod = Convert.ToInt32(dr[0]);
                k.prffstnam = dr[1].ToString();
                k.prflstnam = dr[2].ToString();
                k.prfdsc = Convert.ToString(dr[3]);
                k.prfpic = dr[4].ToString();
                obj.Add(k);
            }
            dr.Close();
            cmd.Dispose();
            con.Close();
            return obj;

        }
    }
    public class clscat : clscon
    {
        public Int32 save_rec(clscatprp prp)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("inscat", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@catnam", SqlDbType.VarChar, 100).Value = prp.catnam;
            cmd.Parameters.Add("@catpic", SqlDbType.VarChar, 50).Value = prp.catpic;
            cmd.Parameters.Add("@r", SqlDbType.Int).Direction =
                    ParameterDirection.ReturnValue;
            cmd.ExecuteNonQuery();
         Int32 a = Convert.ToInt32(cmd.Parameters["@r"].Value);
            cmd.Dispose();
            con.Close();
            return a;
        }
        public void update_rec(clscatprp prp)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("updcat", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@catcod", SqlDbType.Int).Value = prp.catcod;
            cmd.Parameters.Add("@catnam", SqlDbType.VarChar, 100).Value = prp.catnam;
            cmd.Parameters.Add("@catpic", SqlDbType.VarChar, 50).Value = prp.catpic;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
        public void delete_rec(clscatprp prp)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("delcat", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@catcod", SqlDbType.Int).Value = prp.catcod;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
        public List<clscatprp> disp_rec()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("dspcat", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader dr = cmd.ExecuteReader();
            List<clscatprp> obj = new List<clscatprp>();
            while (dr.Read())
            {
                clscatprp k = new clscatprp();
                k.catcod = Convert.ToInt32(dr[0]);
                k.catnam = dr[1].ToString();
                k.catpic = dr[2].ToString();
                obj.Add(k);
            }
            dr.Close();
            cmd.Dispose();
            return obj;
        }
        public List<clscatprp> find_rec(Int32 catcod)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("fndcat", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@catcod", SqlDbType.Int).Value = catcod;
            SqlDataReader dr = cmd.ExecuteReader();
            List<clscatprp> obj = new List<clscatprp>();
            if (dr.HasRows)
            {
                dr.Read();
                clscatprp k = new clscatprp();
                k.catcod = Convert.ToInt32(dr[0]);
                k.catnam = dr[1].ToString();
                k.catpic = dr[2].ToString();
                obj.Add(k);
            }
            dr.Close();
            cmd.Dispose();
            con.Close();
            return obj;

        }
    }
    public class clslescol : clscon
    {
 public DataSet dspusrlescol(Int32 usrcod,Int32 lccod)
        {
 SqlDataAdapter adp = new SqlDataAdapter("dspusrlescol", con);
 adp.SelectCommand.CommandType = CommandType.StoredProcedure;
 adp.SelectCommand.Parameters.Add("@lccod", SqlDbType.Int)
        .Value = lccod;
 adp.SelectCommand.Parameters.Add("@usrcod", SqlDbType.Int)
        .Value = usrcod;
 DataSet ds = new DataSet();
 adp.Fill(ds);
 return ds;
        }
        public DataSet lescoldet(Int32 lccod)
        {
 SqlDataAdapter adp = new SqlDataAdapter("lescoldet", con);
 adp.SelectCommand.CommandType = CommandType.StoredProcedure;
 adp.SelectCommand.Parameters.Add("@lccod", SqlDbType.Int)
        .Value = lccod;
 DataSet ds = new DataSet();
 adp.Fill(ds);
 return ds;
        }

        public DataSet srclescol(Int32 catcod)
        {
  SqlDataAdapter adp = new SqlDataAdapter("srclescol", con);
  adp.SelectCommand.CommandType = CommandType.StoredProcedure;
  adp.SelectCommand.Parameters.Add("@catcod", SqlDbType.Int)
                    .Value = catcod;
  DataSet ds = new DataSet();
  adp.Fill(ds);
  return ds;
        }

        public void updlescolsts(clslescolprp prp)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
       SqlCommand cmd = new SqlCommand("updlescolsts", con);
       cmd.CommandType = CommandType.StoredProcedure;
    cmd.Parameters.Add("@lescolcod", SqlDbType.Int).Value =
                           prp.lescolcod;
cmd.Parameters.Add("@lescolpubsts", SqlDbType.Char, 1).Value
    =prp.lescolpubsts;
cmd.ExecuteNonQuery();
cmd.Dispose();
con.Close();
        }

        public Int32 save_rec(clslescolprp prp)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("inslescol", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@lescolcatcod", SqlDbType.Int).Value = prp.lescolcatcod;
            cmd.Parameters.Add("@lescoltit", SqlDbType.VarChar, 100).Value = prp.lescoltit;
            cmd.Parameters.Add("@lescoldsc", SqlDbType.VarChar, 1000).Value = prp.lescoldsc;
            cmd.Parameters.Add("@lescolpic", SqlDbType.VarChar, 50).Value = prp.lescolpic;
            cmd.Parameters.Add("@lescolusrcod", SqlDbType.Int).Value = prp.lescolusrcod;
            cmd.Parameters.Add("@lescoldat", SqlDbType.DateTime).Value = prp.lescoldat;
            cmd.Parameters.Add("@lescolcst", SqlDbType.Float).Value = prp.lescolcst;
            cmd.Parameters.Add("@lescolsec", SqlDbType.VarChar, 500).Value = prp.lescolsec;
            cmd.Parameters.Add("@lescolpubsts", SqlDbType.Char, 1).Value = prp.lescolpubsts;
            cmd.Parameters.Add("@r", SqlDbType.Int).Direction
                       = ParameterDirection.ReturnValue;
            cmd.ExecuteNonQuery();
        Int32 a = Convert.ToInt32(cmd.Parameters["@r"].Value);
            cmd.Dispose();
            con.Close();
            return a;
        }
        public void update_rec(clslescolprp prp)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("updlescol", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@lescolcod", SqlDbType.Int).Value = prp.lescolcod;
            cmd.Parameters.Add("@lescolcatcod", SqlDbType.Int).Value = prp.lescolcatcod;
            cmd.Parameters.Add("@lescoltit", SqlDbType.VarChar, 100).Value = prp.lescoltit;
            cmd.Parameters.Add("@lescoldsc", SqlDbType.VarChar, 1000).Value = prp.lescoldsc;
            cmd.Parameters.Add("@lescolpic", SqlDbType.VarChar, 50).Value = prp.lescoltit;
            cmd.Parameters.Add("@lescolusrcod", SqlDbType.Int).Value = prp.lescolusrcod;
            cmd.Parameters.Add("@lescoldat", SqlDbType.DateTime).Value = prp.lescoldat;
            cmd.Parameters.Add("@lescolcst", SqlDbType.Float).Value = prp.lescolcst;
            cmd.Parameters.Add("@lescolsec", SqlDbType.VarChar, 500).Value = prp.lescolsec;
            cmd.Parameters.Add("@lescolpubsts", SqlDbType.Char, 1).Value = prp.lescolpubsts;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
        public void delete_rec(clslescolprp prp)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("dellescol", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@lescolcod", SqlDbType.Int).Value = prp.lescolcod;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
      
        public List<clslescolprp> disp_rec(Int32 usrcod)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
         SqlCommand cmd = new SqlCommand("dspmylescol", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@usrcod", SqlDbType.Int).Value = usrcod;
            SqlDataReader dr = cmd.ExecuteReader();
            List<clslescolprp> obj = new List<clslescolprp>();
            while (dr.Read())
            {
                clslescolprp k = new clslescolprp();
                k.lescolcod = Convert.ToInt32(dr[0]);
                k.lescolcatcod = Convert.ToInt32(dr[1]);
                k.lescoltit = dr[2].ToString();
                k.lescoldsc = dr[3].ToString();
                k.lescolpic = dr[4].ToString();
                k.lescolusrcod = Convert.ToInt32(dr[5]);
                k.lescoldat = Convert.ToDateTime(dr[6]);
                k.lescolcst = Convert.ToSingle(dr[7]);
                k.lescolsec = dr[8].ToString();
                k.lescolpubsts = Convert.ToChar(dr[9]);
                obj.Add(k);
            }
            dr.Close();
            cmd.Dispose();
            return obj;
        }
        public List<clslescolprp> find_rec(Int32 lescolcod)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("fndlescol", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@lescolcod", SqlDbType.Int).Value = lescolcod;
            SqlDataReader dr = cmd.ExecuteReader();
            List<clslescolprp> obj = new List<clslescolprp>();
            if (dr.HasRows)
            {
                dr.Read();
                clslescolprp k = new clslescolprp();
                k.lescolcod = Convert.ToInt32(dr[0]);
                k.lescolcatcod = Convert.ToInt32(dr[1]);
                k.lescoltit = dr[2].ToString();
                k.lescoldsc = dr[3].ToString();
                k.lescolpic = dr[4].ToString();
                k.lescolusrcod = Convert.ToInt32(dr[5]);
                k.lescoldat = Convert.ToDateTime(dr[6]);
                k.lescolcst = Convert.ToSingle(dr[7]);
                k.lescolsec = dr[8].ToString();
                k.lescolpubsts = Convert.ToChar(dr[9]);
                obj.Add(k);
            }
            dr.Close();
            cmd.Dispose();
            con.Close();
            return obj;

        }
    }
    public class clsles : clscon
    {
        public Int32 save_rec(clslesprp prp)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("insles", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@leslescolcod", SqlDbType.Int).Value = prp.leslescolcod;
            cmd.Parameters.Add("@lestit", SqlDbType.VarChar, 100).Value = prp.lestit;
            cmd.Parameters.Add("@lesdsc", SqlDbType.VarChar, 500).Value = prp.lesdsc;
            cmd.Parameters.Add("@lestim", SqlDbType.VarChar, 100).Value = prp.lestim;
            cmd.Parameters.Add("@lesfil", SqlDbType.VarChar, 50).Value = prp.lesfil;
            cmd.Parameters.Add("@lesord", SqlDbType.Char, 1).Value = prp.lesord;
            cmd.Parameters.Add("@r", SqlDbType.Int).Direction =
                        ParameterDirection.ReturnValue;
            cmd.ExecuteNonQuery();
         Int32 a = Convert.ToInt32(cmd.Parameters["@r"].Value);
            cmd.Dispose();
            con.Close();
            return a;
        }
        public void update_rec(clslesprp prp)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("updles", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@lescod", SqlDbType.Int).Value = prp.lescod;
            cmd.Parameters.Add("@leslescolcod", SqlDbType.Int).Value = prp.leslescolcod;
            cmd.Parameters.Add("@lestit", SqlDbType.VarChar, 100).Value = prp.lestit;
            cmd.Parameters.Add("@lesdsc", SqlDbType.VarChar, 500).Value = prp.lesdsc;
            cmd.Parameters.Add("@lestim", SqlDbType.VarChar, 100).Value = prp.lestim;
            cmd.Parameters.Add("@lesfil", SqlDbType.VarChar, 50).Value = prp.lesfil;
            cmd.Parameters.Add("@lesord", SqlDbType.Char, 1).Value = prp.lesord;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
        public void delete_rec(clslesprp prp)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("delles", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@lescod", SqlDbType.Int).Value = prp.lescod;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
       
        public List<clslesprp> disp_rec(Int32 colcod)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("dsples", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@colcod", SqlDbType.Int)
                .Value = colcod;
            SqlDataReader dr = cmd.ExecuteReader();
            List<clslesprp> obj = new List<clslesprp>();
            while (dr.Read())
            {
                clslesprp k = new clslesprp();
                k.lescod = Convert.ToInt32(dr[0]);
                k.leslescolcod = Convert.ToInt32(dr[1]);
                k.lestit = dr[2].ToString();
                k.lesdsc = dr[3].ToString();
                k.lestim = dr[4].ToString();
                k.lesfil = dr[5].ToString();
                k.lesord = Convert.ToChar(dr[6]);
                obj.Add(k);
            }
            dr.Close();
            cmd.Dispose();
            return obj;
        }
        public List<clslesprp> find_rec(Int32 lescod)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("fndles", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@lescod", SqlDbType.Int).Value = lescod;
            SqlDataReader dr = cmd.ExecuteReader();
            List<clslesprp> obj = new List<clslesprp>();
            if (dr.HasRows)
            {
                dr.Read();
                clslesprp k = new clslesprp();
                k.lescod = Convert.ToInt32(dr[0]);
                k.leslescolcod = Convert.ToInt32(dr[1]);
                k.lestit = dr[2].ToString();
                k.lesdsc = dr[3].ToString();
                k.lestim = dr[4].ToString();
                k.lesfil = dr[5].ToString();
                k.lesord = Convert.ToChar(dr[6]);
                obj.Add(k);
            }
            dr.Close();
            cmd.Dispose();
            con.Close();
            return obj;

        }
    }
    public class clslesatt : clscon
    {
        public Int32 save_rec(clslesattprp prp)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("inslesatt", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@lesattlescod", SqlDbType.Int).Value = prp.lesattlescod;
            cmd.Parameters.Add("@lesattnam", SqlDbType.VarChar, 100).Value = prp.lesattnam;
            cmd.Parameters.Add("@lesattfil", SqlDbType.VarChar, 50).Value = prp.lesattfil;
            cmd.Parameters.Add("@r", SqlDbType.Int).Direction =
                         ParameterDirection.ReturnValue;
            cmd.ExecuteNonQuery();
            Int32 a = Convert.ToInt32(cmd.Parameters["@r"].Value);
            cmd.Dispose();
            con.Close();
            return a;
        }
        public void update_rec(clslesattprp prp)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("updlesatt", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@lesattcod", SqlDbType.Int).Value = prp.lesattcod;
            cmd.Parameters.Add("@lesattlescod", SqlDbType.Int).Value = prp.lesattlescod;
            cmd.Parameters.Add("@lesattnam", SqlDbType.VarChar, 100).Value = prp.lesattnam;
            cmd.Parameters.Add("@lesattfil", SqlDbType.VarChar, 50).Value = prp.lesattfil;

            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
        public void delete_rec(clslesattprp prp)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("dellesatt", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@lesattcod", SqlDbType.Int).Value = prp.lesattcod;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
      
        public List<clslesattprp> disp_rec(Int32 lescod)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("dsplesatt", con);
            cmd.CommandType = CommandType.StoredProcedure;
          cmd.Parameters.Add("@lescod", SqlDbType.Int).Value =
                                        lescod;
            SqlDataReader dr = cmd.ExecuteReader();
            List<clslesattprp> obj = new List<clslesattprp>();
            while (dr.Read())
            {
                clslesattprp k = new clslesattprp();
                k.lesattcod = Convert.ToInt32(dr[0]);
                k.lesattlescod = Convert.ToInt32(dr[1]);
                k.lesattnam = dr[2].ToString();
                k.lesattfil = dr[3].ToString();
                obj.Add(k);
            }
            dr.Close();
            cmd.Dispose();
            return obj;
        }
        public List<clslesattprp> find_rec(Int32 lesattcod)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("fndlesatt", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@lesattcod", SqlDbType.Int).Value = lesattcod;
            SqlDataReader dr = cmd.ExecuteReader();
            List<clslesattprp> obj = new List<clslesattprp>();
            if (dr.HasRows)
            {
                dr.Read();
                clslesattprp k = new clslesattprp();
                k.lesattcod = Convert.ToInt32(dr[0]);
                k.lesattlescod = Convert.ToInt32(dr[1]);
                k.lesattnam = dr[2].ToString();
                k.lesattfil = dr[3].ToString();
                obj.Add(k);
            }
            dr.Close();
            cmd.Dispose();
            con.Close();
            return obj;

        }
    }
    public class clslesexr : clscon
    {
        public DataSet dsplesexr(Int32 lescod)
        {
 SqlDataAdapter adp = new SqlDataAdapter("dsplesexr", con);
 adp.SelectCommand.CommandType = CommandType.StoredProcedure;
 adp.SelectCommand.Parameters.Add("@lescod", SqlDbType.Int)
     .Value = lescod;
 DataSet ds = new DataSet();
 adp.Fill(ds);
 return ds;
        }

        public Int32 save_rec(clslesexrprp prp)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("inslesexr", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@lesexrtit", SqlDbType.VarChar, 100).Value = prp.lesexrtit;
            cmd.Parameters.Add("@lesexrlescod", SqlDbType.Int).Value = prp.lesexrlescod;
 cmd.Parameters.Add("@r", SqlDbType.Int).Direction = ParameterDirection
                                                         .ReturnValue;
            cmd.ExecuteNonQuery();
            Int32 a = Convert.ToInt32(cmd.Parameters["@r"].Value);
            cmd.Dispose();
            con.Close();
            return a;
        }
        public void update_rec(clslesexrprp prp)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("updlesexr", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@lesexrcod", SqlDbType.Int).Value = prp.lesexrcod;
            cmd.Parameters.Add("@lesexrtit", SqlDbType.VarChar, 100).Value = prp.lesexrtit;
            cmd.Parameters.Add("@lesexrlescod", SqlDbType.Int).Value = prp.lesexrlescod;

            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
        public void delete_rec(clslesexrprp prp)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("dellesexr", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@lesexrcod", SqlDbType.Int).Value = prp.lesexrcod;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
        public List<clslesexrprp> disp_rec()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("dsplesexr", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader dr = cmd.ExecuteReader();
            List<clslesexrprp> obj = new List<clslesexrprp>();
            while (dr.Read())
            {
                clslesexrprp k = new clslesexrprp();
                k.lesexrcod = Convert.ToInt32(dr[0]);
                k.lesexrtit = dr[1].ToString();
                k.lesexrlescod = Convert.ToInt32(dr[2]);
                obj.Add(k);
            }
            dr.Close();
            cmd.Dispose();
            return obj;
        }
        public List<clslesexrprp> find_rec(Int32 lesexrcod)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("fndlesexr", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@lesexrcod", SqlDbType.Int).Value = lesexrcod;
            SqlDataReader dr = cmd.ExecuteReader();
            List<clslesexrprp> obj = new List<clslesexrprp>();
            if (dr.HasRows)
            {
                dr.Read();
                clslesexrprp k = new clslesexrprp();
                k.lesexrcod = Convert.ToInt32(dr[0]);
                k.lesexrtit = dr[1].ToString();
                k.lesexrlescod = Convert.ToInt32(dr[2]);
                obj.Add(k);
            }
            dr.Close();
            cmd.Dispose();
            con.Close();
            return obj;

        }
    }
    public class clsqst : clscon
    {
        public void save_rec(clsqstprp prp)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("insqst", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@qstlecexrcod", SqlDbType.Int).Value = prp.qstlecexrcod;
            cmd.Parameters.Add("@qstdsc", SqlDbType.VarChar, 100).Value = prp.qstdsc;
            cmd.Parameters.Add("@qstord", SqlDbType.Int).Value = prp.qstord;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
        public void update_rec(clsqstprp prp)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("updqst", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@qstcod", SqlDbType.Int).Value = prp.qstcod;
            cmd.Parameters.Add("@qstlecexrcod", SqlDbType.Int).Value = prp.qstlecexrcod;
            cmd.Parameters.Add("@qstdsc", SqlDbType.VarChar, 100).Value = prp.qstdsc;
            cmd.Parameters.Add("@qstord", SqlDbType.Int).Value = prp.qstord;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
        public void delete_rec(clsqstprp prp)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("delqst", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@qstcod", SqlDbType.Int).Value = prp.qstcod;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
       
        public List<clsqstprp> disp_rec(Int32 exrcod)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("dspqst", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@exrcod", SqlDbType.Int).Value =
                                    exrcod;
            SqlDataReader dr = cmd.ExecuteReader();
            List<clsqstprp> obj = new List<clsqstprp>();
            while (dr.Read())
            {
                clsqstprp k = new clsqstprp();
                k.qstcod = Convert.ToInt32(dr[0]);
                k.qstlecexrcod = Convert.ToInt32(dr[1]);
                k.qstdsc = dr[2].ToString();
                k.qstord = Convert.ToInt32(dr[3]);
                obj.Add(k);
            }
            dr.Close();
            cmd.Dispose();
            return obj;
        }
        public List<clsqstprp> find_rec(Int32 qstcod)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("fndqst", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@qstcod", SqlDbType.Int).Value = qstcod;
            SqlDataReader dr = cmd.ExecuteReader();
            List<clsqstprp> obj = new List<clsqstprp>();
            if (dr.HasRows)
            {
                dr.Read();
                clsqstprp k = new clsqstprp();
                k.qstcod = Convert.ToInt32(dr[0]);
                k.qstlecexrcod = Convert.ToInt32(dr[1]);
                k.qstdsc = dr[2].ToString();
                k.qstord = Convert.ToInt32(dr[3]);
                obj.Add(k);
            }
            dr.Close();
            cmd.Dispose();
            con.Close();
            return obj;

        }
    }
    public class clsopt : clscon
    {
        public void save_rec(clsoptprp prp)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("insopt", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@optqstcod", SqlDbType.Int).Value = prp.optqstcod;
            cmd.Parameters.Add("@optdsc", SqlDbType.VarChar, 100).Value = prp.optdsc;
            cmd.Parameters.Add("@optsts", SqlDbType.Char, 1).Value = prp.optsts;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
        public void update_rec(clsoptprp prp)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("updopt", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@optcod", SqlDbType.Int).Value = prp.optcod;
            cmd.Parameters.Add("@optqstcod", SqlDbType.Int).Value = prp.optqstcod;
            cmd.Parameters.Add("@optdsc", SqlDbType.VarChar, 100).Value = prp.optdsc;
            cmd.Parameters.Add("@qststs", SqlDbType.Char, 1).Value = prp.optsts;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
        public void delete_rec(clsoptprp prp)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("delqst", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@optcod", SqlDbType.Int).Value = prp.optcod;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
       
        public List<clsoptprp> disp_rec(Int32 qstcod)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("dspopt", con);
            cmd.Parameters.Add("@qstcod", SqlDbType.Int).Value = qstcod;
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader dr = cmd.ExecuteReader();
            List<clsoptprp> obj = new List<clsoptprp>();
            while (dr.Read())
            {
                clsoptprp k = new clsoptprp();
                k.optcod = Convert.ToInt32(dr[0]);
                k.optqstcod = Convert.ToInt32(dr[1]);
                k.optdsc = dr[2].ToString();
                k.optsts = Convert.ToChar(dr[3]);
                obj.Add(k);
            }
            dr.Close();
            cmd.Dispose();
            return obj;
        }
        public List<clsoptprp> find_rec(Int32 optcod)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("fndopt", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@optcod", SqlDbType.Int).Value = optcod;
            SqlDataReader dr = cmd.ExecuteReader();
            List<clsoptprp> obj = new List<clsoptprp>();
            if (dr.HasRows)
            {
                dr.Read();
                clsoptprp k = new clsoptprp();
                k.optcod = Convert.ToInt32(dr[0]);
                k.optqstcod = Convert.ToInt32(dr[1]);
                k.optdsc = dr[2].ToString();
                k.optsts = Convert.ToChar(dr[3]);
                obj.Add(k);
            }
            dr.Close();
            cmd.Dispose();
            con.Close();
            return obj;

        }
    }
    public class clsenr : clscon
    {
        public DataSet dspstu(Int32 lccod)
        {
            SqlDataAdapter adp = new SqlDataAdapter("dspstu", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.SelectCommand.Parameters.Add("@lccod", SqlDbType.Int).Value
                = lccod;
            DataSet ds = new DataSet();
            adp.Fill(ds);
            return ds;
        }

        public DataSet dsppurles(Int32 usrcod)
        {
            SqlDataAdapter adp = new SqlDataAdapter("dsppurles", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.SelectCommand.Parameters.Add("@usrcod", SqlDbType.Int).Value = usrcod;
            DataSet ds = new DataSet();
            adp.Fill(ds);
            return ds;
        }

        public void save_rec(clsenrprp prp)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("insenr", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@enrdat", SqlDbType.DateTime).Value = prp.enrdat;
            cmd.Parameters.Add("@enrusrcod", SqlDbType.Int).Value = prp.enrusrcod;
            cmd.Parameters.Add("@enrlescolcod", SqlDbType.Int).Value = prp.enrlescolcod;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
        public void update_rec(clsenrprp prp)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("updenr", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@enrcod", SqlDbType.Int).Value = prp.enrcod;
            cmd.Parameters.Add("@enrdat", SqlDbType.DateTime).Value = prp.enrdat;
            cmd.Parameters.Add("@enrusrcod", SqlDbType.Int).Value = prp.enrusrcod;
            cmd.Parameters.Add("@enrlescolcod", SqlDbType.Int).Value = prp.enrlescolcod;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
        public void delete_rec(clsenrprp prp)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("delenr", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@enrcod", SqlDbType.Int).Value = prp.enrcod;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
        public List<clsenrprp> disp_rec()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("dspenr", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader dr = cmd.ExecuteReader();
            List<clsenrprp> obj = new List<clsenrprp>();
            while (dr.Read())
            {
                clsenrprp k = new clsenrprp();
                k.enrcod = Convert.ToInt32(dr[0]);
                k.enrdat = Convert.ToDateTime(dr[1]);
                k.enrusrcod = Convert.ToInt32(dr[2]);
                k.enrlescolcod = Convert.ToInt32(dr[3]);
                obj.Add(k);
            }
            dr.Close();
            cmd.Dispose();
            return obj;
        }
        public List<clsenrprp> find_rec(Int32 enrcod)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("fndenr", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@enrcod", SqlDbType.Int).Value = enrcod;
            SqlDataReader dr = cmd.ExecuteReader();
            List<clsenrprp> obj = new List<clsenrprp>();
            if (dr.HasRows)
            {
                dr.Read();
                clsenrprp k = new clsenrprp();
                k.enrcod = Convert.ToInt32(dr[0]);
                k.enrdat = Convert.ToDateTime(dr[1]);
                k.enrusrcod = Convert.ToInt32(dr[2]);
                k.enrlescolcod = Convert.ToInt32(dr[3]);
                obj.Add(k);
            }
            dr.Close();
            cmd.Dispose();
            con.Close();
            return obj;

        }
    }
    public class clsdis : clscon
    {
        public DataSet dspdis(Int32 lccod)
        {
            SqlDataAdapter adp = new SqlDataAdapter("dspdis", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.SelectCommand.Parameters.Add("@lccod", SqlDbType.Int).Value
                            = lccod;
            DataSet ds = new DataSet();
            adp.Fill(ds);
            return ds;
        }

        public void save_rec(clsdisprp prp)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("insdis", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@dislescod", SqlDbType.Int).Value = prp.disleccod;
            cmd.Parameters.Add("@disusrcod", SqlDbType.Int).Value = prp.disusrcod;
            cmd.Parameters.Add("@distit", SqlDbType.VarChar, 100).Value = prp.distit;
            cmd.Parameters.Add("@disdsc", SqlDbType.VarChar, 500).Value = prp.disdsc;
            cmd.Parameters.Add("@disrep", SqlDbType.VarChar, 500).Value = prp.disrep;
            cmd.Parameters.Add("@disdat", SqlDbType.DateTime).Value = prp.disdat;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
        public void update_rec(clsdisprp prp)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("upddis", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@discod", SqlDbType.Int).Value = prp.discod;
            //cmd.Parameters.Add("@disleccod", SqlDbType.Int).Value = prp.disleccod;
           // cmd.Parameters.Add("@disusrcod", SqlDbType.Int).Value = prp.disusrcod;
         //   cmd.Parameters.Add("@distit", SqlDbType.VarChar, 100).Value = prp.distit;
         //   cmd.Parameters.Add("@disdsc", SqlDbType.VarChar, 500).Value = prp.disdsc;
            cmd.Parameters.Add("@disrep", SqlDbType.VarChar, 500).Value = prp.disrep;
       //     cmd.Parameters.Add("@disdat", SqlDbType.DateTime).Value = prp.disdat;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
        public void delete_rec(clsdisprp prp)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("delenr", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@discod", SqlDbType.Int).Value = prp.discod;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
        public List<clsdisprp> disp_rec()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("dspenr", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader dr = cmd.ExecuteReader();
            List<clsdisprp> obj = new List<clsdisprp>();
            while (dr.Read())
            {
                clsdisprp k = new clsdisprp();
                k.discod = Convert.ToInt32(dr[0]);
                k.disleccod = Convert.ToInt32(dr[1]);
                k.disusrcod = Convert.ToInt32(dr[2]);
                k.distit = dr[3].ToString();
                k.disdsc = dr[4].ToString();
                k.disrep = dr[5].ToString();
                k.disdat = Convert.ToDateTime(dr[6]);
                obj.Add(k);
            }
            dr.Close();
            cmd.Dispose();
            return obj;
        }
        public List<clsdisprp> find_rec(Int32 discod)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("fnddis", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@discod", SqlDbType.Int).Value = discod;
            SqlDataReader dr = cmd.ExecuteReader();
            List<clsdisprp> obj = new List<clsdisprp>();
            if (dr.HasRows)
            {
                dr.Read();
                clsdisprp k = new clsdisprp();
                k.discod = Convert.ToInt32(dr[0]);
                k.disleccod = Convert.ToInt32(dr[1]);
                k.disusrcod = Convert.ToInt32(dr[2]);
                k.distit = dr[3].ToString();
                k.disdsc = dr[4].ToString();
                k.disrep = dr[5].ToString();
                k.disdat = Convert.ToDateTime(dr[6]);
                obj.Add(k);
            }
            dr.Close();
            cmd.Dispose();
            con.Close();
            return obj;

        }
    }

}
