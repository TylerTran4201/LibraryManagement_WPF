   M S B A M L   `   `   `  ����  WPF_LibraryManagement+    %WPF_LibraryManagement.frmCategoryEdit   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -   5          � Title$  frmCategoryEdit��5   	   $	��300��6!   $	��550��6.    � WindowStyle$
 None=�5   	    � WindowState$ Normal=�6    � WindowStartupLocation$ CenterScreen=�5	   	   
������  � 
ResizeMode$ NoResize=�5
   "    � AllowsTransparency .  � 	Resources 5         BorderDataGrid �� 
TargetType&   System.Windows.Controls.DataGrid �� 	Resources	 �� Property
 �� Value  BorderButton��%H  &	        &	 �     �� 5   
   "  6'    5      ���� 5      '��       " ��6   .�5      �� 	 �@��CornerRadius$
 5��65   5      5      5      �� 5   
   " ��6%    5      ���� 5      '��       " ��6   .�5      �� 	 �@��CornerRadius$
 7��65   5      5      5      5      .��5      ��  �� CornerRadius$ 5��6   $��2q�6   
����+��  SecundaryBackgroundColor#���  6K   ._�5   
   �  � RowDefinitions 5      �� 5       $��30 �6    �� 5!      �� 5"      $��50 �6    .+�5$      � $��0��6   .+�5%      �� $��Select Category��6   
���   �$��15(�6E   $
��Bold"�6S   $��Center=�6e   $��Center=�6�   5&      � 5'      $��1��6   $	��Top=�6    .+�5(        -   5        $��	dtgAuthor��5)         AutoGenerateColumns .     CanUserAddRows .     SelectionMode$ Single=�5+         
IsReadOnly .    CanUserResizeColumns .  $	��400��5.      $��5q�5/        BorderColor#���  50      #��[  51      ��52      �� *
Categories+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�   Columns 53      0  *System.Windows.Controls.DataGridTextColumn  54      ,  &System.Windows.Controls.DataGridColumn   Header$ Id��6-      Width5  /System.Windows.Controls.DataGridLengthConverter$ 50 55   -   1  +System.Windows.Controls.DataGridBoundColumn   Binding 56   -   �� *Id+  57      $
 Name��6-   $	 250 58   -    59   -   �� *Name+4  .System.Windows.Controls.DataGridTemplateColumn  5:      $ 20 61      CellTemplate 5;      �� 5<   "   .R�5=   &   ��  ��Name$ 	btnSelect��6-   -   5        
������ $��0q�5?   -   $��20��5A   -   $��20��68   $��Center=�5B   -   $��Center=�5C   -    � Cursor$
 Hand��5D   -   .��5E   *   F� $��2q�6/     Tick#��[ 5F   /   #���  5G   /    �� Stretch$
 Fill=�5H   /   5I   '   5J   #   5L      5N      5O      � 5P      $��2��6   .+�5Q      � $��Center=�6   $��Center=�62   .+�5R      �� -   5        $��btnExit��5R   �   
������ #���  66   #���  6a   $	��100��6�   $��20��6�   $
��Back��6�   #��[ 6�   5S      5T      5U      5V      5W      5X      