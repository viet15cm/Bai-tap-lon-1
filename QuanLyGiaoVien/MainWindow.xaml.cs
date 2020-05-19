using OpenQA.Selenium;
using QuanLyGiaoVien.ConnectionDatabase;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace QuanLyGiaoVien
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        private string xau()
        {
            string strConnect = "Server=" + txb_Sever.Text + ";Database=" + txb_Database.Text +
                ";User Id=" + txb_User.Text + ";Password=" + txb_Password.Password + ";Integrated Security=SSPI";
           
            return strConnect;
        }
       

        private void Connection(object sender, RoutedEventArgs e)
        {
            if (checkEmpty())
            {
                string connectionString = ConfigurationManager.ConnectionStrings["QLGV"].ConnectionString;
                if (Fixbugs.duplicateErrors(xau()))
                {
                    ConnecCSDL.conection();
                    Window1 window1 = new Window1();
                    window1.Show();
                    this.Close();

                }


                else
                    MessageBox.Show("Kết Nối Không Thành Công Tài Khoảng Không Khớp");
            }
            else
            
                MessageBox.Show("Bạn Chưa Nhập Thông Tin Đầy Đủ");
            
        }

        private bool checkEmpty()
        {
            if (Fixbugs.emptyError(txb_Database.Text) && Fixbugs.emptyError(txb_Sever.Text)
                && Fixbugs.emptyError(txb_User.Text) && Fixbugs.emptyError(txb_Password.Password))
                return true;
            return false;
        }


        private void canceButton()
        {
            MessageBoxResult key = MessageBox.Show(
             "Bạn có muốn thoắt khỏi from kết nối",
             "Thoắt",
             MessageBoxButton.YesNo,
             MessageBoxImage.Question,
             MessageBoxResult.No);
            if (key == MessageBoxResult.No)
            {
                return;
            }
            else
            {
                Application.Current.Shutdown();
            }
        }

        private void Close(object sender, RoutedEventArgs e)
        {
            canceButton();
        }

        private void txb_User_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
