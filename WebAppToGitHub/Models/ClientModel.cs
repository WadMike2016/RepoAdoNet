using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Web;

namespace WebAppToGitHub.Models
{
    public class ClientModel
    {
        #region Fields
        private int _IdClient;
        private string _NomClient;
        private string _PrenomClient;
        private DateTime _DateNaissance;
        private string _TelClient;
        private string _MailClient;
        private string _RueClient;
        private string _VilleClient;
        private string _CodePostalClient;
        private string _Login;
        private string _Password;
        private bool? _sexe;
        #endregion
        #region Properties
        [KeyAttribute]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdClient
        {
            get { return _IdClient; }
            set { _IdClient = value; }
        }
        [Required]
        [Display(Name="Nom")]
        public string NomClient
        {
            get { return _NomClient; }
            set { _NomClient = value; }
        }
        [Required]
        [Display(Name = "Prénom")]
        public string PrenomClient
        {
            get { return _PrenomClient; }
            set { _PrenomClient = value; }
        }
        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Date de Naissance")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime DateNaissance
        {
            get { return _DateNaissance; }
            set { _DateNaissance = value; }
        }
        
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Téléphone")]
        public string TelClient
        {
            get { return _TelClient; }
            set { _TelClient = value; }
        }
       
        [Required]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email")]
        public string MailClient
        {
            get { return _MailClient; }
            set { _MailClient = value; }
        }
        
        
        
        [Required]
        [Display(Name = "Rue - N°")]
        public string RueClient
        {
            get { return _RueClient; }
            set { _RueClient = value; }
        }
        [Required]
        [Display(Name = "Ville")]
        public string VilleClient
        {
            get { return _VilleClient; }
            set { _VilleClient = value; }
        }
        [Required]
        [Display(Name = "Code postal")]
        public string CodePostalClient
        {
            get { return _CodePostalClient; }
            set { _CodePostalClient = value; }
        }
        [Required]
        [Display(Name = "Login")]
        public string Login
        {
            get { return _Login; }
            set { _Login = value; }
        }
        [Required]
        [Display(Name = "Password")]
        [MaxLength(15, ErrorMessage="Maximum 15 caractères")]
        [MinLength(3,ErrorMessage="Minimum 3 caractères")]
        [DataType(DataType.Password)]
        public string Password
        {
            get { return _Password; }
            set { _Password = value; }
        }
        
        public bool? Sexe
        {
            get { return _sexe; }
            set { _sexe = value; }
        }
        #endregion
        
        /// <summary>
        /// Saves this instance on database
        /// </summary>
        /// <returns>true if save is ok</returns>
        public bool Save()
        {
            //1 - Connexion
            SqlConnection oConn = new SqlConnection();
            //1.1 - Chemin vers le serveur ==> ConnectionString
            oConn.ConnectionString = @"Data Source=MIKEW8\TFTIC2012;Initial Catalog=MedicoDb;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False";
            //1.2 - Ouvrir la connexion
            try
            {
                oConn.Open();

                //2 - Commande
                SqlCommand oCmd =
                    new SqlCommand(@"INSERT INTO [dbo].[Client]
           ([NomClient]
           ,[PrenomClient]
           ,[DateNaissance]
           ,[TelClient]
           ,[MailClient]
           ,[RueClient]
           ,[VilleClient]
           ,[CodePostalClient]
           ,[Login]
           ,[Password]
           ,[Sexe])
     VALUES
           (@NomClient
           ,@PrenomClient
           ,@DateNaissance
           ,@TelClient
           ,@MailClient
           ,@RueClient
           ,@VilleClient
           ,@CodePostalClient
           ,@Login
           ,@Password
           ,@Sexe)"
                                   , oConn);


                //3 - Ajout des paramètres

               SqlParameter pNomClient = new SqlParameter();
               pNomClient.ParameterName = "@NomClient";
               pNomClient.Value = this.NomClient;
               SqlParameter pPrenomClient = new SqlParameter();
               pPrenomClient.ParameterName = "@PrenomClient";
               pPrenomClient.Value = this.PrenomClient;
               SqlParameter pDateNaissance = new SqlParameter();
               pDateNaissance.ParameterName = "@DateNaissance";
               pDateNaissance.Value = this.DateNaissance;
               SqlParameter pTelClient = new SqlParameter();
               pTelClient.ParameterName = "@TelClient";
               pTelClient.Value = this.TelClient;
               SqlParameter pMailClient = new SqlParameter();
               pMailClient.ParameterName = "@MailClient";
               pMailClient.Value = this.MailClient;
               SqlParameter pRueClient = new SqlParameter();
               pRueClient.ParameterName = "@RueClient";
               pRueClient.Value = this.RueClient;
               SqlParameter pVilleClient = new SqlParameter();
               pVilleClient.ParameterName = "@VilleClient";
               pVilleClient.Value = this.VilleClient;
               SqlParameter pCodePostalClient = new SqlParameter();
               pCodePostalClient.ParameterName = "@CodePostalClient";
               pCodePostalClient.Value = this.CodePostalClient;
               SqlParameter pLogin = new SqlParameter();
               pLogin.ParameterName = "@Login";
               pLogin.Value = this.Login;
               SqlParameter pPassword = new SqlParameter();
               pPassword.ParameterName = "@Password";
               pPassword.Value = this.Password;
               SqlParameter pSexe = new SqlParameter();
               pSexe.ParameterName = "@Sexe";
                if(this.Sexe.HasValue)
                {
                    pSexe.Value = this.Sexe.Value;
                }
                else
                {
                    pSexe.Value = DBNull.Value;
                }
               


               oCmd.Parameters.Add(pNomClient);
               oCmd.Parameters.Add(pPrenomClient);
               oCmd.Parameters.Add(pDateNaissance);
               oCmd.Parameters.Add(pTelClient);
               oCmd.Parameters.Add(pMailClient);
               oCmd.Parameters.Add(pRueClient);
               oCmd.Parameters.Add(pVilleClient);
               oCmd.Parameters.Add(pCodePostalClient);
               oCmd.Parameters.Add(pLogin);
               oCmd.Parameters.Add(pPassword);
               oCmd.Parameters.Add(pSexe);

               oCmd.ExecuteNonQuery();
                
                //4 - Fermer la connexion
                oConn.Close();
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }
        
        /// <summary>
        /// Get Client from DB which has the parameter pseudo
        /// </summary>
        /// <returns>A <seealso cref="ClientModel"/> if pseudo exist, Null if not</returns>
        public static ClientModel getOneFromPseudo(string Pseudo)
        { //1 - Connexion
            SqlConnection oConn = new SqlConnection();
            //1.1 - Chemin vers le serveur ==> ConnectionString
            oConn.ConnectionString = @"Data Source=MIKEW8\TFTIC2012;Initial Catalog=MedicoDb;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False";
            //1.2 - Ouvrir la connexion
            try
            {
                oConn.Open();

                //2 - Commande
                SqlCommand oCmd =
                    new SqlCommand(@"Select * from Client where Login=@pseudo"
                                   , oConn);


                //3 - Ajout des paramètres

               SqlParameter pPseudo = new SqlParameter();
               pPseudo.ParameterName = "@pseudo";
               pPseudo.Value = Pseudo;
               oCmd.Parameters.Add(pPseudo);
               ClientModel Client = null;
               SqlDataReader oDr = oCmd.ExecuteReader();
                if(oDr.HasRows)
                {
                    oDr.Read();
                    Client = InstanceFromOdr(oDr);
                    
                }
                oDr.Close();
                //4 - Fermer la connexion
                oConn.Close();

                return Client;
            }
            catch (Exception ex)
            {
                return null;
            }
         
        }

        private static ClientModel InstanceFromOdr(SqlDataReader oDr)
        {
            ClientModel Client = new ClientModel();
            foreach (PropertyInfo item in Client.GetType().GetProperties())
            {
                item.SetValue(Client, oDr[item.Name]);
            }
            return Client;
        }
    }
}