   M S B A M L   `   `   `  ����  WPF_LibraryManagement&     WPF_LibraryManagement.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	     � Title$  
MainWindow��5   	   $	��700��6   $
��1050��6)    � WindowStyle$
 None=�5   	    � WindowStartupLocation$ CenterScreen=�6   
������  � AllowsTransparency .  � 
ResizeMode$ NoResize=�5
   	    � WindowState$ Normal=�6   .��5      ��  �� CornerRadius$ 8��6      PrimaryBackgroundColor#���   6   ._�5   
   �  � ColumnDefinitions 5      �� 5      $
��auto �6#   �� 5      .+�5      �� $ 8 0 0 8��6     SecundaryBackgroundColor#���  6,   ._�5      � -   5         �Name$ gridMenu��5      $��60��6)   	 � RowDefinitions	 5      �� 5      $��60 �6(   �� 5      $��80 �6(   �� 5      $
��Auto �6(   �� 5      .+�5      �� $��1��6!   
 �� Orientation$
 
Horizontal=�6.   $	��top=�6G   .+�5      F�   logo#���  6   $��13 0 0 0q�6=    �� Stretch$
 Fill=�6O     PrimaryColor#���  6^   $��40��6�   $��40��6�   $��Center=�6�   �� 5      $��Library App��6    #���  66   $
��Bold"�6b   $��15(�6t   $��Center=�6�   $��Center=�6�   $
��Left=�6�   $��3 0 0 0q�6�   5      d� 5       -   5         d�Name$ btnMenu��5    #   $��Right=�64   $��0q�6P   
������ $��Center=�6}     MenuIconStyle#��[ 6�   $��0 0 15 0q�6�    � Triggers 5!      :� 5"       :� RoutedEvent$ ToggleButton.Unchecked��6+   .[�5#   "   �� .��5$   &   �� -   5         ��Name$ HideStackPanel��5$   1   .��5%   *   W�  �� 
TargetName$ gridMenu��6:    �� TargetProperty$ Width�6[    g� 	BeginTime$ 0:0:0X�6}    W� From$	 200X�6�   	 W� To$ 60X�6�    g� Duration$ 0:0:0.3D�6�   5&   '   5'   #   5(      :� 5)      $ ToggleButton.Checked��6+   .[�5*   "   �� .��5+   &   �� -   5        $ ShowStackPanel��5+   1   .��5,   *   W� $ gridMenu��6:   $ Width�6[   $ 0:0:0X�6}   $ 60X�6�   $	 200X�6�   $ 0:0:0.3D�6�   5-   '   5.   #   5/      51      �� 53      $��3��6!   .+�54      	� -   5         	�Name$ rdReaderManagement��54   &   $��Reader��6B     MenuRadioButtonStyle#���  6S     ReaderManagement
 � Tag# �  6�   6�   	� 55      -   5        $ rdBookManagement��55   &   $
��Book��6@   #���  6O     BooksManagement# �  6~   6�   	� 56      -   5        $ rdBorrowBooks��56   &   $��Borrow Books��6=   #���  6T     BorrowBooks# �  6�   6�   	� 57      -   5        $ rdReturnBooks��57   &   $��Return Books��6=   #���  6T    	 ReturnBooks# � 	 6�   6�   	� 58      -	   5        $ rdStatistical��58   &   $��
Statitical��6=   #���  6R    
 Statistical# � 
 6�   6�   59      �� 5:      $��3��6!   $��Bottom=�6.   $
 
Horizontal=�6I   $	��200��6b   $��0 0 0 20q�6n   .+�5;      A� $��40��6"   $��40��6-   $��13 0 0 0q�69   ��5<      �� 5=   "    �� ImageSource$  Assets/AvatarPics/avt1.jpg��6-   5?      �� 5@      $
 Vertical=�6%   $��8 0 0 0q�6<   .+�5A      �� $��Tran Dong Tri��6$     TextPrimaryColor#���  6<   $��14(�6l   $��SemiBold"�6z   $��Center=�6�   $
��Left=�6�   �� 5B      $ ��trandongtri.work@gmail.com��6$     PrimaryGrayColor#���  6I   $��11(�6y   $��Regular"�6�   $��Center=�6�   $
��Left=�6�   $��-7 0 0 0q�6�   5C      5D      5E      5F      � 5I      $��1��6   	 5J      �� 5K      $��60 �6$   �� 5L      $	��41* �6$   �� 5M      $
��549* �6$   .+�5Q      �� $��0��6   $��Right=�6*   $	��Top=�6F   $��0,5,10,0q�6^   $��30��6p   $
 
Horizontal=�6|   $��RightToLeft=�6�   .+�5R      �� -
   5         ��Name$ btnClose��5R        IconButtonsStyle#��[ 6/    	 close#���  6Y   $ IsCloseButton��6{   6�   5S      �� 5V      $��1��6   $��10q�6&   $��2��62   ._�5W       � -   5          �Name$ PagesNavigation��5W        � NavigationUIVisibility$ Hidden=�65   5Y      5Z      5[      5]      5^      5_      