   M S B A M L   `   `   `  ����@  <lab 8, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:lab_8lab_8  5   	   O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5   	       lab_8.view_Window   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:lab_8     5   	   9System&clr-namespace:System;assembly=mscorlib     5   	     � Title$  view_Window��5	   	   $	��450��6   $	��800��6*   .��5
      � .+�5   
   �� -   5         ��Name$ 
del_button��5      $��Delete��6%   $
��Left=�66   $��454,383,0,0q�6Q   $	��Top=�6f   $��75��6~   �� 5   
   -   5        $ reload_button��5      $��Reload��6(   $
��Left=�69   $��587,383,0,0q�6T   $	��Top=�6i   $��75��6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ 	data_view��5      $
��Left=�6&   $	��147��6A   $��
220,96,0,0q�6N   $	��Top=�6b   $	��377��6z      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ id��6e   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   ��  �� Path$ id�   ClipboardContentBinding 6B   Z� 6e     5      $
 name��6g    6%   �� $
 name� 6D   Z� 6g     5      $	 age��6f    6%   �� $	 age� 6C   Z� 6f   5      5      5      