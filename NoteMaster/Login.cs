using Firebase.Auth.Providers;
using Firebase.Auth.Repository;
using Firebase.Auth;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NoteMaster.Controls;

namespace NoteMaster
{
    public partial class Login : Form
    {
        private string AuthDomain, ApiKey;
        private SignUp signUp;
        private LoginUC loginUC;
        private FirebaseAuthClient client;

        public Login(string AuthDomain, string ApiKey)
        {
            InitializeComponent();
            this.AuthDomain = AuthDomain;
            this.ApiKey = ApiKey;
             
            signUp = new SignUp();
            loginUC = new LoginUC();
         
            importLoginBtn_Click(this, EventArgs.Empty);

            this.loginUC.LoginBtn.Click += LoginBtn_Click;
            this.signUp.SignUpBtn.Click += SignUpBtn_Click;


             FirebaseAuthConfig config = new FirebaseAuthConfig
            {
                ApiKey = ApiKey,
                AuthDomain = AuthDomain,
                Providers = new FirebaseAuthProvider[]{ new EmailProvider()},
               
            };
              this.client = new FirebaseAuthClient(config);
        }

        private async void SignUpBtn_Click(object sender, EventArgs e)
        {
            try
            {
                UserCredential userCredential = await client.CreateUserWithEmailAndPasswordAsync(this.signUp.emailTxt.Text.Trim(), this.signUp.passwordTxt.Text.Trim());
                MessageBox.Show("Kayıt Başarılı,Giriş yapabilirsiniz!");

            }
            catch (Exception exc)
            {
                MessageBox.Show("HATA: " + exc.Message);
            }
            finally
            {

            }
        }

        private async void LoginBtn_Click(object sender, EventArgs e)
        {
            try
            {
                UserCredential userCredential = await client.SignInWithEmailAndPasswordAsync(this.loginUC.emailTxt.Text.Trim(), this.loginUC.passwordTxt.Text.Trim());
                MessageBox.Show("Giriş Başarılı!");

            }
            catch(Exception exc) { 
               MessageBox.Show("HATA: "+exc.Message);
            }
            finally
            {

            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(signUp);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void importLoginBtn_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(loginUC);
        }

       
  

        }
    
    }

