   M S B A M L   `   `   `  ����C  ?Elibrary, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:ElibraryElibrary  5   	   d `Syncfusion.PdfViewer.WPF, Version=19.4460.0.38, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89mLclr-namespace:Syncfusion.Windows.PdfViewer;assembly=Syncfusion.PdfViewer.WPFSyncfusion.Windows.PdfViewer 5   	       Elibrary.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:Elibrary     5   	   b	PdfViewerLclr-namespace:Syncfusion.Windows.PdfViewer;assembly=Syncfusion.PdfViewer.WPF     5   	     � Title$  Библиотека��5	   	   $��301.866��6   $��636.432��6-    � DataContext 5
        Elibrary.MainViewModel  5   
   .��5      � $��0,0,2,0q�6    � ColumnDefinitions 5   
   �� 5      $
��644* �6   .+�5   
   � $
��Left=�6   $	��176��6*   $��
450,10,0,0q�67   $	��Top=�6K   $	��174��6c    � RowDefinitions 5      �� 5      $��7* �6    �� 5      $
��169* �6     5      �� 5      $	��17* �6#   �� 5      $	��83* �6#   .+�5      �� $
��Left=�6   $	��100��64   $��-4,0,0,0q�6A   $	��Top=�6S   $	��100��6k   $��2��6w   $��2��6�   �� 5      $��Добавить
��6   $
��Left=�6-   $	��Top=�6H   $	��165��6`   $��47��6l   $��20(�6x   $��2��6�   $��0,55,0,0q�6�   $��1��6�   �� 5      $��Удалить
��6   $
��Left=�6,   $	��Top=�6G   $	��165��6_   $��47��6k   $��20(�6w   $��2��6�   $��	0,107,0,0q�6�   $��1��6�   �� 5      $��Открыть
��6   $
��Left=�6,   $	��Top=�6G   $	��165��6_   $��47��6k   $��20(�6w   $��0,3,0,0q�6�   $��2��6�   $��1��6�   5      �� 5   
   $��
Книги��6   $��0,0,819,617q�6"   z�5       V� 5!      .~�5"      �� �� 5#      �� 5$       �� Angle$ 0.101Q�6&   T� 5%      5&      .��5(      �� $	��130��5+      $y�Hidden=�6*   ��5)      �� *
BooksAll+ �� SelectedItem 5*      �� *BooksAllChoosen+��5,      �� 5-      .R�5.      �  5/      �� 50   "   $��60 �63   �� 51   "   $��* �63   �� 52   "   $��* �63   .+�54      �� $��0��6)   ��69   �� *Name+�� 55      $��1��6)   ��69   �� *Author+56      57      59      5:      &   System.Windows.Controls.DataGrid  5;   
      
IsReadOnly .    ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 5=         ColumnHeaderHeight$ 30Q�5>      $��13(�5?      $��Center=�5@      	 J� RenderTransformOrigin$	 0.473,0.511&�5A   {   $��	0,0,181,0q�6�   ��6   �� *LTable[0].DefaultView+
 �� UpdateSourceTrigger$
 PropertyChanged=� �� Mode$ OneWay=�6�   5F      5G      