   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5   	       WpfApp1.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp1     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $	��63* �6   �� 5      $	��97* �6   �� 5      $��0* �6   .+�5   
   �� $
��Left=�6   $��	29,23,0,0q�6/   $
��Wrap=�6B   $��Simple Point Postioning��6V   $	��Top=�6u   $��16��6�   $	��126��6�   �� 5   
   -   5         ��Name$ 
GPS_ChkBox��5      $	��GPS��6'   $
��Left=�65   $��	29,74,0,0q�6P   $	��Top=�6c   
����������	#FF353535$
��Bold"�6�    d� 	IsChecked$
 TrueY�6�   $��15��6�   $��42��6�   �� 5   
   -   5        $ QZSS_ChkBox��5      $
��QZSS��6(   $
��Left=�67   $��	29,94,0,0q�6R   $	��Top=�6e   
����������	#FF353535$
��Bold"�6�   $ FalseY�6�   $��15��6�   $��49��6�   �� 5   
   -   5        $ BeiDou_ChkBox��5      $��BeiDou��6*   $
��Left=�6;   $��
29,114,0,0q�6V   $	��Top=�6j   
����������	#FF353535$
��Bold"�6�   $ FalseY�6�   $��15��6�   $��60��6�   �� 5   
   -   5        $ GLONASS_ChkBox��5      $��GLONASS��6+   $
��Left=�6=   $��
29,134,0,0q�6X   $	��Top=�6l   
����������	#FF353535$
��Bold"�6�   $ FalseY�6�   $��15��6�   $��73��6�   	� 5   
   -   5         	�Name$ Hello_Button��5      $��Hello��6,   $
��Left=�6<   $��
29,177,0,0q�6W   $	��Top=�6k   $
��Bold"�6�   $
 TrueY�6�   $��15��6�   $��48��6�   	� 5   
   -   5        $ GoodBye_Button��5      $��GoodBye��6.   $
��Left=�6@   $��
29,197,0,0q�6[   $	��Top=�6o   $
��Bold"�6�   $ FalseY�6�   $��15��6�   $��69��6�   �� 5   
   -   5         ��Name$ Display_Button��5      $��Display Button��6)   $
��Left=�6B   $��
29,257,0,0q�6]   $	��Top=�6q   $��20��6�   $��81��6�   �� 5   
   -   5        $
��Left=�5      $��
29,221,0,0q�6-    �� TextWrapping$
 Wrap=�6A   $��Drag & Drop��6U   $	��Top=�6l   $	��120��6�   $��18��6�    J� 	AllowDrop$
 True��6�    �� TextAlignment$ Center=�6�   
�������6�   �� 5   
   -	   5        	 ��Name$	 	ComboBox1��5      $
��Left=�6&   $��
29,295,0,0q�6A   $	��Top=�6U   $��97��6m   $
{�True��6�   
 �� SelectedIndex$
 0��6�   #��� ��6�   .@�5      �� $��Single��6   �� 5      $��DGNSS��6   �� 5      $��Static��6   �� 5      $��	Kinematic��6   �� 5      $��
PPP-Static��6   �� 5      $��PPP-Kinematic��6   5      �� 5    
   $
��Left=�6   $��
29,334,0,0q�6.   $	��Top=�6B   $	��120��6Z   $
 0��6f   .@�5!      �� $��Saastaminen��6   �� 5"      $
��Mops��6   �� 5#      $��Estimate ZTD��6   �� 5$      $��Estimate ZTD+Grad��6   5%      5&      5'      