   M S B A M L   `   `   `  ����K  GEbedrendeles_WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM+clr-namespace:Ebedrendeles_WPF.UserControlsEbedrendeles_WPF.UserControls  5      *    $Ebedrendeles_WPF.UserControls.ucAlaC   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      =local+clr-namespace:Ebedrendeles_WPF.UserControls     5      .��5	      � .+�5
   
   �� .��5      ��   �� Orientation$  Vertical=�6   .+�5      �� $��Alacarte��6   $��Center=�6+   $��24(�6H   $y�Visible=�6V   �� 5      $  
Horizontal=�6   $��Center=�66   .+�5      &   System.Windows.Controls.DataGrid  -   5          Name$ dgAlac��5         AutoGenerateColumns .     SelectionMode$ Single=�6h      SelectionUnit$ FullRow=�6   $��Center=�6�   $	��Top=�6�   $��10q�6�   $y�Visible=�6     CanUserAddRows .  ��6+   �� *
enEtelek+ �� SelectedItem 6�   ��  �� Path$ SelectedFood� �� Mode$ OneWay=�	   Columns	 5      0  *System.Windows.Controls.DataGridTextColumn  5      -   5        etelekID��,  &System.Windows.Controls.DataGridColumn
   Header$
 Id��5   ?      
IsReadOnly .    
Visibility$ 	Collapsed=�6z   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6]   �� *
etelekId+6z   4  .System.Windows.Controls.DataGridTemplateColumn  5      $

 Kép��61      Width5  /System.Windows.Controls.DataGridLengthConverter$	 100 6>    .    CellTemplate 5      �� 5   "   .R�5   &   �� $��70��6C   $��70��6N   ��6,   �� *kep+6N   5   #   5        5      $
 Megnevezés��6-   $	 200 6A    .  6_   �� *nev+  5      $
 
Kategória��6-   $	 100 6@    .  6^   �� *	kategoria+  5      $
 Ár (Ft)��6-   $ 50 6>    .  6[   �� *ar+5!      �� 5"      -   5         ��Name$ btSave��5"      $��Kosárba��6-   $��Right=�6?   $��11(�6[   $y�Hidden=�6i   $��20��6}   6�   (  "System.Windows.Controls.DatePicker  5#      -   5          Name$ dpDate��5#   !   $��Center=�61   $
��10,0q�6L   $y�Hidden=�6Z   5$      5&      5'      5(      5)      