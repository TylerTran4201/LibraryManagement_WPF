   M S B A M L   `   `   `  ����  WPF_LibraryManagement*    $WPF_LibraryManagement.BookManagement   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      $	��940��5      $	��590��6     � 	Resources  5      ��%    5
      .��5      ��  �� CornerRadius$ 5��6      SecundaryBackgroundColor#���   6   ._�5   
   �  � RowDefinitions 5      �� 5      $��40 �6    �� 5      $	��100 �6    �� 5      .+�5      �� $��Book Management��6     
TitleLabel#���  6.   � 5      $��1��6    � ColumnDefinitions 5      �� 5      �� 5      .+�5      � $��0��6    5      �� 5      �� 5      .+�5      � $��1��6   .+�5      �� #��[ 6    $��	Category:��5        $
��Left=�5!       $��	100 0 0 0q�5"       $��15(�5#         BorderColor#���  5$       �� 5%      -   5         ��Name$ cbCategories��5%   #   $	��200��5&      $��25��5'      $��0 0 80 0q�5(      $��Right=�5)       � Cursor$
 Hand��5*        ComboBoxItemStyle1#���  5+       �� DisplayMemberPath$
 Name��5-      ��5,      �� *
Categories+5-      5.      5/      � 50      $��1��6    51      �� 52      �� 53      .+�55      �� -   5        $��
AddNewBook��55   :   $��Center=�6     SubmitButton#��[ 6L   .��56      �� .+�58      �� $��Add New Book��6$   
�������6;   59      5:      � 5;      $��1��6   .+�5<      �� #��[ 6    $��	Search by��5=       $
��Left=�5>       $��30 0 0 0q�5?       $��15(�5@       #���  5A       �� 5B      $��	115 0 0 0q�6#   $��70��66   $��25��6A   $
��Left=�5C   #   $
 Hand��5D   #   #���  5E   #   .@�5F      �� .��6+   Id6/   �� 5G      .��6+   Name61   5H      �� 5I        	SearchBox#���  6"   $��Right=�5J   "   $��
0,10,30,13q�5K   "   5L      5M      5N      &   System.Windows.Controls.DataGrid  5P      -   5          Name$ BooksDataGrid��5U      $��2��5P        DataGridRowStyle1   RowStyle# �  5Q        DataGridColumnHeaderStyle1	   ColumnHeaderStyle#	 �  5R        DataGridCellStyle1
   	CellStyle#
 �  5S       	 DataGridStyle1#��� 	 5T      $��10q�5U   .   ��5V      ��  �� ElementName$ cbCategories�� �� Path$ SelectedItem.Books� �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�   Columns 5W      0  *System.Windows.Controls.DataGridTextColumn  5X      ,  &System.Windows.Controls.DataGridColumn   Header$ Id��6)      
IsReadOnly .    Width5  /System.Windows.Controls.DataGridLengthConverter$	 150 6G   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6S   �� *Id+  5Y      $
 Name��6)    . $	 250 6I    6U   �� *Name+  5Z      $ Category��6)    . $	 150 6M    6Y   �� *
Category+  5[      $ Pushlish Name��6)    . $	 200 6R    6^   �� *PushlishName+4  .System.Windows.Controls.DataGridTemplateColumn  5]      $ 
Operations��6-    . $	 200 6S      CellTemplate 5^      �� 5_      .R�5`   "   ��  �� Orientation$ 
Horizontal=�6-   .+�5a   &   ��  
 gridEditButton#��� 
 6-   .��5b   *   F�  
 update#���  6/   $��16��5c   /   $��16��5d   /   
������� �� Stretch$ Uniform=�5f   /   $��Center=�5g   /   5h   '   �� 5i   &     gridRemoveButton#���  6-   $��5 0 0 0q�6X   .��5j   *   F�  
 delete#���  6/   $��16��5k   /   $��16��5l   /   
�������$ Uniform=�5n   /   $��Center=�5o   /   5p   '   �� 5q   &   $��btnInfor��5s   -   -   5          gridInforButton#���  5q   -   $��5 0 0 0q�5r   -   .��5t   *   F�  	 infor#���  6/   $��16��5u   /   $��16��5v   /   
�������$ Uniform=�5x   /   $��Center=�5y   /   5z   '   5{   #   5|      5~      5�      5�      5�      5�      