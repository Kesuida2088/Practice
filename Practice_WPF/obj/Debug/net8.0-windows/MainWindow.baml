   M S B A M L   `   `   `  ����G  CPractice_WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:Practice_WPFPractice_WPF  5   	   #    WpfTotorialSamples.MainWIndow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:Practice_WPF     5   	     � Title$  
MainWindow��5   	   $	��200��6   $	��400��6)    � UseLayoutRounding$
 True��65   .��5      � $��10q�6    � ColumnDefinitions 5	   
   �� 5
      $
��Auto �6   �� 5      $��9* �6   �� 5      $	��68* �6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   c� .@�5      ��  � ToolTip$ Create a new file��6   ��5      �� 5      $��component/Images/file.png��6   $��16��6?   $��16��6J   5      �� 5      ��5      �� 5      $!��component/Images/folder.jpg��6   $��20��6A   $��20��6L    5      �� 5      .+�5      �� $
��Bold"�6$   $��14(�66   $��0,0,5,0q�6D   �� 5       &$Serch your computer or local network�� 5"      %#for a file and open it for editing.5$      �� 5%      
�������$��0,0,1,0q�66   $	��0.8q�6P   �� 5&      $��Italic$�6$   Press F1 for more help6O   5'      5)      5*      �� 5,   
   $��2��6   $��1��6   $��2��6/   .��6C   area16J   �� 5-   
   $��2��6   $��1��6   $��2��6/   .��6C   ares26J   5.      5/      