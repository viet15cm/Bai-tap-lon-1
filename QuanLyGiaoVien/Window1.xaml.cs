using QuanLyGiaoVien.ClassObject;
using QuanLyGiaoVien.ConnectionDatabase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using System.Windows.Shapes;

namespace QuanLyGiaoVien
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();



            displayData_CoSo();

        }

        List<GiaoVien> giaoVien;
        List<DonVi> donVi;
        List<CoSo> coSo;
      

      

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            close();
        }

        //Hiển thị bảng giáo viên
        public void displayDataGV(string s)
        {
            giaoVien = ConnecCSDL.readGiaoVienWhere(s);
            listWSach.ItemsSource = giaoVien;

        }

        // chọn giáo viên từ bảng
        private GiaoVien chooseGiaoVien()
        {
            int temp = 0;
            if (listWSach.ItemsSource != null)
            {
                if (listWSach.SelectedIndex != -1)
                {
                    temp = listWSach.SelectedIndex;
                    return giaoVien[temp];
                }
                return null;
            }
            return null;
        }

        private DonVi chooseDonVi()
        {
            int temp = 0;
            if (listWSach.ItemsSource != null)
            {
                if (cbxDonVi.SelectedIndex != -1)
                {
                    temp = cbxDonVi.SelectedIndex;
                    return donVi[temp];
                }
                return null;
            }
            return null;
        }

        private CoSo chooseCoSo()
        {
            int temp = 0;
            if (listWSach.ItemsSource != null)
            {
                if (cbxCoSo.SelectedIndex != -1)
                {
                    temp = cbxCoSo.SelectedIndex;
                    return coSo[temp];
                }
                return null;
            }
            return null;
        }


        //bắt sự kiện hiển thị thông tin chi tiết của giáo viên qua from
        private void HienThiGV(object sender, RoutedEventArgs e)
        {
            Window2 window2 = new Window2();
            if (chooseGiaoVien() != null && chooseDonVi() != null && chooseCoSo() != null)
            {
                window2.txblHTV.Text = chooseGiaoVien().HoTen;

                window2.txblSDT.Text = chooseGiaoVien().SoDT;
                window2.txblGC.Text = chooseGiaoVien().GhiChu;
                window2.txblDVDT.Text = chooseDonVi().TenDonVi;
                window2.txblCS.Text = chooseCoSo().TenCoSo;
                window2.Show();
            }
            else
            {
                MessageBox.Show("Co Lỗi Bạn Chưa chon giáo viên có lỗi null xãy ra");
            }
            
        }

        private void deleteGiaoVien()
        {
            MessageBoxResult key = MessageBox.Show(
             "Bạn có muốn xóa giáo viên :[" + chooseGiaoVien().HoTen + "] ra khỏi danh sách",
             "Xóa",
             MessageBoxButton.YesNo,
             MessageBoxImage.Question,
             MessageBoxResult.No);
            if (key == MessageBoxResult.No)
            {
                return;
            }
            else
            {
                if (chooseGiaoVien() != null)
                {
                    int xoa = ConnecCSDL.DeleteData(chooseGiaoVien());

                    giaoVien = ConnecCSDL.readGiaoVienWhere(cbxDonVi.SelectedValue.ToString());
                    listWSach.ItemsSource = giaoVien;
                }
                else
                    MessageBox.Show("Lỗi Bạn Chưa chọn Giáo Viên");
            }
        }


        //Xóa giáo viên đã chọn
        private void ClearGV(object sender, RoutedEventArgs e)
        {

            deleteGiaoVien();
        }
        
        private void displayData_DonVi()
        {
           cbxDonVi.Items.Clear();
           donVi = ConnecCSDL.readDonVi(cbxCoSo.SelectedValue.ToString());
                foreach (DonVi dv in donVi)               
                    cbxDonVi.Items.Add(dv.MaDonVi);                           
        }

        //Bắt Sự Kiện Chọn combox đơn vị
        private void combox_SelectionChanged_DonVi(object sender, SelectionChangedEventArgs e)
        {
            if (cbxDonVi.SelectedIndex != -1)
                displayDataGV(cbxDonVi.SelectedValue.ToString());
        }

        public void displayData_CoSo()
        {
            coSo = ConnecCSDL.readCoso();
            foreach (CoSo cs in coSo)
                cbxCoSo.Items.Add(cs.MaCoSo);
        }
        private void combox_SelectionChanged_CoSo(object sender, SelectionChangedEventArgs e)
        {
            listWSach.ItemsSource = null;
            displayData_DonVi();

        }

        private void listWSach_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Window2 window2 = new Window2();
            if (chooseGiaoVien() != null && chooseDonVi() != null && chooseCoSo() != null)
            {
                window2.txblHTV.Text = chooseGiaoVien().HoTen;

                window2.txblSDT.Text = chooseGiaoVien().SoDT;
                window2.txblGC.Text = chooseGiaoVien().GhiChu;
                window2.txblDVDT.Text = chooseDonVi().TenDonVi;
                window2.txblCS.Text = chooseCoSo().TenCoSo;
                window2.Show();
            }
            else
            {
                MessageBox.Show("Co Lỗi Bạn Chưa chon giáo viên có lỗi null xãy ra");
            }
        }

        public void close()
        {
            MessageBoxResult key = MessageBox.Show(
             "Bạn có muốn thoắt ",
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

    }
}
