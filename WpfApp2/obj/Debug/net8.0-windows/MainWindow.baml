   M S B A M L   `   `   `  ����B  >WpfApp2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp2WpfApp2  5   	       WpfApp2.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp2     5   	     � Title$  Read OBS file��5   	   $	��450��6   $	��800��6,   .��5	      � $��10q�6    � ColumnDefinitions 5
   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $��20 �6   �� 5      $��30 �6   �� 5      $��40 �6   �� 5      $��30 �6   �� 5      $��* �6   .+�5   
   �� -   5         ��Name$ btn_OpenFile��5      $��Open OBS file��6'   $��0��6?   $��0��6O   6\   �� 5   
   -   5         ��Name$ txtblk_OBSFilePath��5      $��1��6.   $��2��6?   $��0��6S   $��3q�6`   �� 5   
   -   5        $ btn_OpenNAVFile��5      $��Open NAV file��6*   $��0��6B   $��1��6R   $��0,10,0,0q�6}   �� 5   
   -   5        $ txtblk_NAVFilePath��5      $��1��6.   $��2��6?   $��1��6S   $��3q�6`   $��0,10,0,0q�6u   �� 5   
   -   5        $ btn_Excute_Header��5      $��
OBS HEADER��6,   $��0��6A   $��2��6Q   $��0,10,0,0q�6{   �� 5    
   -   5        $ btn_Excute_Body��5       $��OBS BODY��6*   $��1��6=   $��2��6M   $��5,10,0,0q�6v   �� 5!   
   $	��GPS��6   $��3��6!   $��2��61   $��Center=�6>   �� 5"   
   $
��QZSS��6   $��4��6"   $��2��62   $��Center=�6?   �� 5#   
   $��Galileo��6   $��5��6%   $��2��65   $��Center=�6B   �� 5$   
   $��BeiDou��6   $��6��6$   $��2��64   $��Center=�6A   �� 5%   
   $��GLONASS��6   $��7��6%   $��2��65   $��Center=�6B   �� 5&   
   $
��Data��6   $��0��6   $��3��6/   $��Bottom=�6<   �� 5'   
   -   5        $ txtblk_DisplayOBSData��5'      $��4��61   $��4��6E   $��2q�6R   5(      5)      