   M S B A M L   `   `   `  ����P  LWPF_LibraryManagement, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:WPF_LibraryManagementWPF_LibraryManagement  5      b ^PresentationFramework.Aero2, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35hKclr-namespace:Microsoft.Windows.Themes;assembly=PresentationFramework.Aero2Microsoft.Windows.Themes 6G   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089   DataGridStyle1  �� 
TargetType&    System.Windows.Controls.DataGrid �� Property �� Value5  /System.Windows.Controls.DataGridLengthConverter �� 
TargetType �� Padding J� SnapsToDevicePixels ��Name � ColumnDefinitions � RowDefinitions	    SelectAllCommand
 �� 
ResourceId �� TypeInTargetAssembly7  1System.Windows.Controls.DataGridHeadersVisibility
   All �� ConverterParameter!    HeadersVisibilityConverter �� 	Converter �� RelativeSource �� AncestorTypeG  ASystem.Windows.Controls.Primitives.DataGridColumnHeadersPresenter  Name   Column ��Name �� CanContentScroll ��Name �� ScrollableHeight � Maximum �� Orientation* �� #ComputedVerticalScrollBarVisibility �� ViewportHeight �� ViewportSize � Value �� Mode �� ScrollableWidth,  �� %ComputedHorizontalScrollBarVisibility! �� ViewportWidth" �� Triggers# ]� 
Conditions$ �� Property% �� Value  DataGridRowStyle1)  #System.Windows.Controls.DataGridRow& ��Name' �� CornerRadius?  9System.Windows.Controls.Primitives.SelectiveScrollingGrid?  9System.Windows.Controls.Primitives.DataGridCellsPresenter(   
ItemsPanelA  ;System.Windows.Controls.Primitives.DataGridDetailsPresenter)   DetailsVisibility$*   SelectiveScrollingOrientation;  5System.Windows.Controls.SelectiveScrollingOrientation+   Vertical#,    RowDetailsScrollingConverter:	  4System.Windows.Controls.Primitives.DataGridRowHeader
-   Row. P� Property/ P� Value  ColumnHeaderGripperStyle  DataGridColumnHeaderStyle1=
  7System.Windows.Controls.Primitives.DataGridColumnHeader3  -Microsoft.Windows.Themes.DataGridHeaderBorder0 
  CanUserSort1   IsClickable2   	IsPressed3 J� IsMouseOver4   	IsHovered5 
  SortDirection6   SortDirection7 
  SeparatorBrush8   SeparatorBrush9 
  SeparatorVisibility:   SeparatorVisibility; n�Name  DataGridCellStyle1*  $System.Windows.Controls.DataGridCell  gridEditButton  gridRemoveButton< �� BasedOn  gridInforButton�� 5      D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    :x,http://schemas.microsoft.com/winfx/2006/xaml     5      -local#clr-namespace:WPF_LibraryManagement  5      VThemesKclr-namespace:Microsoft.Windows.Themes;assembly=PresentationFramework.Aero2  6G   %  &	        &	 j
    &	 j    &	 |    7  7  &	     &	 �    &	 �    7  &	 	    7  �� 5      "    6#   .�5   
   ��  � ��
 ���� 6'   �� 5   
    � �� �#2225286'   �� 5   
    � ��$ 0q�6,   �� 5	   
     �@  RowDetailsVisibilityMode$ VisibleWhenSelected=�65   �� 5
   
    � �� . 6:   �� 5   
    �@��PanningMode$
 Both=�65   �� 5   
    �@��IsFlicksEnabled .  63   �� 5   
    �@  HeadersVisibility$ Column=�6.   �� 5   
    � ��$ 0 10 0 0q�6#   �� 5   
    �@  SelectionMode$ Single=�6*   �� 5   
    �@  SelectionUnit$ FullRow=�6*   �� 5   
    �@  CanUserAddRows .  6+   �� 5   
    �@  CanUserDeleteRows .  6.   �� 5   
    �@  CanUserResizeRows .  6.   �� 5   
    �@  CanUserReorderColumns .  62   �� 5   
    � ��$ 13(�6%   �� 5   
    �@  ColumnWidth$ * 6(   �� 5   
    �@  GridLinesVisibility$
 None=�60   �� 5   
    � �� 5      �� 5      "   6"   .R�5      �� #��z��6   #��z��6I   #��z��6}   # z��6�    . ._�5      �� $ DG_ScrollViewer��6'   |�.  ��5      �� 5   "   " ��62   .R�5    &   �  5!   *   �� 5"   .   $
��Auto �6?   �� 5#   .   $��* �6?   �� 5$   .   $
��Auto �6?    5&   *   �� 5'   .   $
��Auto �6<   �� 5(   .   $��* �6<   �� 5)   .   $
��Auto �6<   .+�5+   *   �� #��Z	 61   |�.  ��6r   C� *�� $"
 DataGridSelectAllButtonStyle��"   +y�6�   �� *HeadersVisibility+# Z # Z  �� "   ��6�  �� *CellsPanelHorizontalOffset+ �� "     5,   *   $! PART_ColumnHeadersPresenter��6I   $��1��6n   y�6~   �� *HeadersVisibility+# Z # Z  �� "   �� 5-   *   $! PART_ScrollContentPresenter��6A   # z��6f   $��2��6�   $��1��6�   �� 5.   *   $ PART_VerticalScrollBar��64   $��2��6T   # z 6d   $ Vertical=�6�   $��1��6�   #y�z 6�   # z 6W   6�   �� *VerticalOffset+$ OneWay=� �� *TemplatedParent+6W  � 5/   *   $��1��6/   $��2��6?    50   .   �� 51   2   ��6C   �� **(NonFrozenColumnsViewportHorizontalOffset+ �� "   �� 52   2   $��* �6C   .+�54   .   �� $ PART_HorizontalScrollBar��68   $��1��6Z   # z 6j   $ 
Horizontal=�6�   #y�z  6�   # z! 6U   6�   �� *HorizontalOffset+$ OneWay=� �� *TemplatedParent+6U  55   +   56   '   57   #   .��59      �� # z 6-   5:      5;      5<      5>      " 5?   
   ]� 5@      # 5A      �� 5B      $ �@��
IsGrouping% . 66   �� 5C      "$ �@%�IsVirtualizingWhenGrouping% .  6X   ./�5E      ��  � �� .  6B   5F      5H      �� 5J      "   6&   .�5K   
   ��  � ��
 �����6'   �� 5L   
    � ��$ 0 4 0 0q�6#   �� 5M   
    �@J�SnapsToDevicePixels . 60   �� 5N   
    �@�Cursor$
 Hand��6#   �� 5O   
    �@=�ErrorTemplate 65   Z� �� 5P   
    �@ ValidationErrorTemplate 5Q      �� 5R      .R�5S      �� 
���  ��$��2,0,0,0q�61   $��!��6B   $��Center=�6K   5T      5V      �� 5W   
    � �� 5X      �� 5Y      "  6"   .R�5Z      �� $& 
DGR_Border��6   $	 0 8q�61   $��0q�6?   #��z��6S   $' 5��6}    . ._�5[         5\      �� 5]   "   $
��Auto �63   �� 5^   "   $��* �63    5`      �� 5a   "   $��* �60   �� 5b   "   $
��Auto �60   .+�5d        $��1��65   #��z( 6E   # z 6o     5e      $��1��67   $��1��6G   #y�z) 6k  * 6T   �� *AreRowDetailsFrozen+# Z+ # Z,  �� "   6k  	  5f      $��2��60   $* Vertical=�6A   y�6�   �� *HeadersVisibility+# Z- # Z  �� "   5g      5h      5i      5k      " 5l   
   P� 5m      . �@J�IsMouseOver/ . . �5n      ��  � �� �#623ed06/   �� 5o       � �� �#ffffff6/   5p      P� 5q      . �@ 
IsSelected/ . . �5r      ��  � �� �#623ed06/   �� 5s       � �� �#ffffff6/   5t      ]� 5u      # 5v      �� 5w      $ �@ 
IsSelected% . 66   �� 5x      $ �@��IsSelectionActive% .  6F   ./�5z      ��  � �� �#dfdfdf6/   5{      5}      �� 5      "  n�6-   .�5�   
   ��  � ��$ 8��6"   �� 5�   
    � ��
 ���� 6'   �� 5�   
    �@�Cursor$ SizeWE��6#   �� 5�   
    � �� 5�      �� 5�      " n�6"   .R�5�      �� #��z��6   # z��6G   5�      5�      5�      �� 5�      "  
 6/   .�5�   
   ��  � ��$ Center=�65   �� 5�   
    � ��
 ���� 6'   �� 5�   
    � �� �#69717d6'   �� 5�   
    � ��$ 
15 0 15 10q�6#   �� 5�   
    � �� 5�      �� 5�      " 
 6"   .R�5�      � .+�5�        #��z��66   #��z��6b   #��z��6�   #1 z0 6�   #2 z��6�   #4 z3 6  # z��6>  #6 z5 6b  #8 z7 6�  #: z9 6�  ._�5�      �� #��z��6/   ��. # z 6�   #��z��6�   5�      n� 5�      $; PART_LeftHeaderGripper��6    $
��Left=�6@   8��  6[   n� 5�      $; PART_RightHeaderGripper��6    $��Right=�6A   8�� 6]   5�      5�      5�      5�      �� 5�      "   6'   .�5�   
   ��  � ��
 ���� 6'   �� 5�   
    � ��$ Center=�6.   �� 5�   
    �@�FocusVisualStyle 6-   Z� �� 5�   
    � ��$
 15 0q�6#   �� 5�   
    � �� 5�      �� 5�      "  6"   .R�5�      �� $��0q�6   #��z��61    . ._�5�      �� # z 6+   5�      5�      5�      5�      �� 5�      "  ��6#   .�5�   
   ��  � �� �#512da86'   �� 5�   
    � �� �#4a148c6(   �� 5�   
    � �� �#ffffff6'   �� 5�   
    �@�FocusVisualStyle 6-   Z� �� 5�   
    � ��$ Center=�6.   �� 5�   
    �@�Cursor$
 Hand��6#   �� 5�   
    � �� 5�      �� 5�      " ��6"   .R�5�      �� #��z��6   $' 5��6G   $ 5q�6X   $��1q�6d   #��z��6x   ._�5�      �� $��Center=�6+   $��Center=�6H   5�      5�      5�      " 5�   
   P� 5�      . �@J�IsMouseOver/ . . �5�      ��  � �� �#673ab76/   5�      5�      �� 5�      "  ��6%   8<   .�5�   
   ��  � �� �#d32f2f6'   �� 5�   
    � �� �#b71c1c6(   �� 5�   
    �@�Cursor$
 Hand��6#   " 5�   
   P� 5�      . �@J�IsMouseOver/ . . �5�      ��  � �� �#f443366/   5�      5�      �� 5�      "  ��6$   8<   .�5�   
   ��  � �� �#e396106'   �� 5�   
    � �� �#c98f2a6(   �� 5�   
    �@�Cursor$
 Hand��6#   " 5�   
   P� 5�      . �@J�IsMouseOver/ . . �5�      ��  � �� �#fcb5386/   5�      5�      5�      