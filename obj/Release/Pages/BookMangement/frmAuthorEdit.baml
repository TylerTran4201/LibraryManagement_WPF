   M S B A M L   `   `   `  ����   WPF_LibraryManagement)    #WPF_LibraryManagement.frmAuthorEdit   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     -     � Title$  frmAuthorEdit��$	��300��$	��550�� � WindowStyle$
 None=� � WindowState$ Normal=� � WindowStartupLocation$ CenterScreen=�
������  � 
ResizeMode$ NoResize=� � AllowsTransparency .  � 	Resources    BorderDataGrid �� 
TargetType&   System.Windows.Controls.DataGrid �� 	Resources	 �� Property
 �� Value  BorderButton��%�   &	        &	 L     �� "   ���� '��       " ��.��� 	 �@��CornerRadius$
 5���� " �� ���� '��       " ��.��� 	 �@��CornerRadius$
 7��.����  �� CornerRadius$ 5��$��2q�
����+��  SecundaryBackgroundColor#���  ._��  � RowDefinitions �� $��30 ��� �� $��50 �.+�� $��0��.+��� $��Select Author��
���   �$��15(�$
��Bold"�$��Center=�$��Center=�� $��1��$	��Top=�.+�  -   $��	dtgAuthor��   AutoGenerateColumns .     CanUserAddRows .     SelectionMode$ Single=�   
IsReadOnly .    CanUserResizeColumns .  $	��400��$��5q�  BorderColor#���  #��[  ���� *	Authors+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�   Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$ Id��   Width5  /System.Windows.Controls.DataGridLengthConverter$ 50 1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *Id+  $
 Name��$	 250  �� *Name+4  .System.Windows.Controls.DataGridTemplateColumn  $ 20    CellTemplate �� .R���  ��Name$ checkboxTick��-    d� 	IsChecked �� *	IsCheck+$ TwoWay=�$ PropertyChanged=�� $��2�� � ColumnDefinitions �� $	��275 ��� .+�� $��0��$��Center=�$��Center=�.+��� -   $��	btnChange��#���  $��0q�
�������$	��100��$��20��$��Change��#��[ � $��1��$��Center=�$��Center=�.+��� -   $��btnExit��
������ #���  #���  $	��100��$��20��$
��Back��#��[ 