   M S B A M L   `   `   `  ����  WPF_LibraryManagement)    #WPF_LibraryManagement.frmAuthorEdit   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -   5          � Title$  frmAuthorEdit��5   	   $	��300��6   $	��550��6,    � WindowStyle$
 None=�5   	    � WindowState$ Normal=�6    � WindowStartupLocation$ CenterScreen=�5	   	   
������  � 
ResizeMode$ NoResize=�5
   "    � AllowsTransparency .  � 	Resources 5         BorderDataGrid �� 
TargetType&   System.Windows.Controls.DataGrid �� 	Resources	 �� Property
 �� Value  BorderButton��%H  &	        &	 �     �� 5   
   "  6'    5      ���� 5      '��       " ��6   .�5      �� 	 �@��CornerRadius$
 5��65   5      5      5      �� 5   
   " ��6%    5      ���� 5      '��       " ��6   .�5      �� 	 �@��CornerRadius$
 7��65   5      5      5      5      .��5      ��  �� CornerRadius$ 5��6   $��2q�6   
����+��  SecundaryBackgroundColor#���  6K   ._�5   
   �  � RowDefinitions 5       �� 5!      $��30 �6    �� 5"      �� 5#      $��50 �6    .+�5%      � $��0��6   .+�5&      �� $��Select Author��6   
���   �$��15(�6C   $
��Bold"�6Q   $��Center=�6c   $��Center=�6~   5'      � 5(      $��1��6   $	��Top=�6    .+�5)        -   5        $��	dtgAuthor��5*         AutoGenerateColumns .     CanUserAddRows .     SelectionMode$ Single=�5,         
IsReadOnly .    CanUserResizeColumns .  $	��400��5/      $��5q�50        BorderColor#���  51      #��[  52      ��53      �� *	Authors+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�   Columns 54      0  *System.Windows.Controls.DataGridTextColumn  55      ,  &System.Windows.Controls.DataGridColumn   Header$ Id��6-      Width5  /System.Windows.Controls.DataGridLengthConverter$ 50 56   -   1  +System.Windows.Controls.DataGridBoundColumn   Binding 57   -   �� *Id+  58      $
 Name��6-   $	 250 59   -    5:   -   �� *Name+4  .System.Windows.Controls.DataGridTemplateColumn  5;      $ 20 61      CellTemplate 5<      �� 5=   "   .R�5>   &   ��  ��Name$ checkboxTick��6/   -   5         d� 	IsChecked 5B   /   �� *	IsCheck+$ TwoWay=�$ PropertyChanged=�5D   #   5F      5H      5I      � 5J      $��2��6    � ColumnDefinitions 5K      �� 5L      $	��275 �6'   �� 5M      .+�5O      � $��0��6   $��Center=�6'   $��Center=�6B   .+�5P      �� -   5        $��	btnChange��5P   �   #���  6   $��0q�6H   
�������$	��100��6o   $��20��6{   $��Change��6�   #��[ 6�   5Q      5R      � 5S      $��1��6   $��Center=�6'   $��Center=�6B   .+�5T      �� -   5        $��btnExit��5T   �   
������ #���  66   #���  6a   $	��100��6�   $��20��6�   $
��Back��6�   #��[ 6�   5U      5V      5W      5X      5Y      5Z      