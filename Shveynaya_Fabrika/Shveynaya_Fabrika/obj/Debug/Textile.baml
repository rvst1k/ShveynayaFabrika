   M S B A M L   `   `   `  ����L  HShveynaya_Fabrika, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:Shveynaya_FabrikaShveynaya_Fabrika  5   	       Shveynaya_Fabrika.Textile   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:Shveynaya_Fabrika     5   	     � Icon$  resources\logo-01.jpg��5   	    � Title$ 
Ткань��5	   	   $	��450��6   $	��700��6$   .��5
      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   .+�5   
   ��  �� Orientation$ 
Horizontal=�6   $��RightToLeft=�6.   .+�5      �� -   5        $
��Exit��5   "   $��1��6      
DiffButton#��[  6.   $��
Выход��6e   $��Right=�6u   $��10,10,10,10q�6�   �� 5      -   5        $
��Back��5   "   $��1��6   #��[  6.   $��
Назад��6e   $��Right=�6u   $��
0,10,10,10q�6�   5      &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ TextileGrid��5      $��2��6(   $��3��65   $��Center=�6F   $��Center=�6c   $��4��6~   $��0��6�      AutoGenerateColumns .  $	��300��5      $	��600��6*      
IsReadOnly .    ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 6H   $��0,20,0,0q�6X      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn	   Header$	 Артикул��6%   
   
FontWeight$
 
ExtraLight"�6R   1  +System.Windows.Controls.DataGridBoundColumn   Binding 66   �� *	Articul+6l     5      $	 Название��6%   $
 
ExtraLight"�6T    67   �� *
Nazvanie+6n     5      $	 Ширина��6%   $
 
ExtraLight"�6Q    65   �� *	Shirina+6k     5      $	 
Длина��6%   $
 
ExtraLight"�6N    64   �� *Dlina+6h     5      $	 Цена��6%   $
 
ExtraLight"�6M    63   �� *Price+6g   5      5       5!      