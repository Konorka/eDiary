   M S B A M L   `   `   `  ����H  DKoNorBeadando, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:KoNorBeadandoKoNorBeadando  5   	       KoNorBeadando.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:KoNorBeadando     5   	   -   5          � Title$  
MainWindow��5   	   $��479.261��6   $��878.977��6-    � 	Resources 5	      !   KoNorBeadando.eDiaryDataSet   eDiaryDataSet  lessonViewSource �� Source �� Source��%W   &	        &	      7     5
   
   6   �� 5   
    68   �� *Lesson+8   5      .��5      �  � DataContext# [ 6   .+�5   
   &   System.Windows.Controls.DataGrid  $
��Left=�6   $	��285��6.   $��	10,93,0,0q�6;   $	��Top=�6N   $	��851��6f   $��3��6r   {�.   5      =  7System.Windows.Controls.Primitives.DataGridColumnHeader �� 
TargetType �� Property �� Value��%V   '        �� 5      "  6   .�5      ��  � ��$ Center=�6C   5      5         Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn	   Header$	 	2018/2019��6%   
   Width5  /System.Windows.Controls.DataGridLengthConverter$
 70 68     5      $	 
I. Félév��6%   $
 * 67     5      $	 II. Félév��6%   $
 * 68     5      $	 Átlag��6%   $
 40 64     5      $	 Hiányzások��6%   $	
 140 69   5        5    
   -   5          Name$ DataGridStudent��5    C   # [ 6      AutoGenerateColumns .     EnableRowVirtualization . $
��Left=�6�   $	��263��6�   $��
10,115,0,0q�6�   $	��Top=�6�   $	��851��6  $��3��6     RowDetailsVisibilityMode$ VisibleWhenSelected=�6$  ��6�   ��  5!      ��%V   '        �� 5"      "  6   .�5#      ��  � ��$ Center=�6C   5$      5%       5'        5(      $	 Tantárgyak��6E   $
 70 6Y   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *lesson_name+6Y     5)      $	 09��6%   $
 * 61     5*      $	 10��6%   $
 * 61     5+      $	 11��6%   $
 * 61     5,      $	 12��6%   $
 * 61     5-      $	 01��6%   $
 * 61     5.      $	 	I. Átlag��6%   $
 * 67     5/      $	 02��6%   $
 * 61     50      $	 03��6%   $
 * 61     51      $	 04��6%   $
 * 61     52      $	 05��6%   $
 * 61     53      $	 06��6%   $
 * 61     54      $	 
II. Átlag��6%   $
 * 68     55      $	  ��6%   $
 40 6/     56      $	 Igazolt��6%   $
 70 66     57      $	 Igazolatlan��6%   $
 70 6:   5:      �� 5;   
   -   5         ��Name$ 	nameLabel��5;      $�� ��6#   $
��Left=�6.   $��	10,10,0,0q�6I   $	��Top=�6\   $��68��6t   $	��355��6�   �� 5<   
   -   5        $��Kijelentkezés��5<      $
��Left=�6)   $��
786,43,0,0q�6D   $	��Top=�6X   $��75��6p   6{   5=      5>      