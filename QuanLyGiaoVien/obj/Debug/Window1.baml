   M S B A M L   `   `   `  ����I  EQuanLyGiaoVien, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:QuanLyGiaoVienQuanLyGiaoVien  5   	       QuanLyGiaoVien.Window1   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:QuanLyGiaoVien     5   	     � Title$  Window1��5   	   $	��450��6   $	��600��6&    � 	Resources 5	         bellRingersFontStyle �� 
TargetType �� Property �� Value  textBoxMenu��%H  &	        &	 S     7   �� 5
   
   " ��6-   .�5      ��  � ��$ Comic Sans MS)�6+   5      �� 5   
   8��  .@�5      m� $��	HienThiGV��6=   -   5        $)��#Hiển thị thông tin giáo viên��5      6N   m� 5      $��ClearGV��6/   -   5        $��Xóa giáo viên ��5      6>   5      5      .��5      � $��0,0,2,0q�6   .+�5   
   �� -   5        $��Thoắt��5      $
��Left=�6!   $��34��6<   $��358,356,0,0q�6H   $	��Top=�6]   $	��106��6u   6�   �� 5   
   -   5        $��	listWSach��5   s   $
��Left=�6   $	��119��6.   $	��Top=�6;   $	��366��6S   $��
98,216,0,0q�6_    � ContextMenu# [ 6�    �� View 5      �� 5      .P�5      �� $	��STT��6%    �� Width$ 50��62    �� DisplayMemberBinding 6=   �� *STT+�� 5      $��Họ Tên Giáo Viên��6%   $	 200��6?    6K   �� *HoTen+5      5      �� 5   
   -   5        $��cbxDonVi��5   D   $
��Left=�6T   $��30��6o   $��204,120,0,0q�6{   $	��Top=�6�   $	��256��6�   �� 5   
   -   5        $��cbxCoSo��5   C   $
��Left=�6R   $��32��6m   $��
204,58,0,0q�6y   $	��Top=�6�   $	��256��6�   �� 5   
   $��Cơ Sỡ : ��6   $
��Left=�6#   $��	98,58,0,0q�6>   $	��Top=�6Q   $��80��6i   $��32��6t   �� 5    
   $��Đơn vị đào tạo :��6   $
��Left=�6+   $��
97,124,0,0q�6F   $	��Top=�6Z   $	��102��6r   �� 5!   
   $��Danh sách giáo viên :��6   $
��Left=�60   $��
97,185,0,0q�6K   $	��Top=�6_   $	��123��6w   5'      5)      