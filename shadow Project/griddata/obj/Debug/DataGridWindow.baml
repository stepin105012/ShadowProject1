   M S B A M L   `   `   `  ����C  ?griddata, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:griddatagriddata  5   	       griddata.DataGridWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:griddata     5   	   $	��600��5   	   $
��1000��6   
����ح�.��5	      � $��10q�6   .+�5
   
   &   System.Windows.Controls.DataGrid  -   5        $��Student��5
          AutoGenerateColumns  .  $	��700��6>   $��16(�6J   $��Normal$�6X   $��5q�6k   $��137,0,136.6,348.4q�6      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$
 Name��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 63   �� *Name+   	CellStyle 5      �� 5       �� 
TargetType*  $System.Windows.Controls.DataGridCell"  6    .�5      ��  �� Property � �� �� Value
 �   �6L   5      5        5      $ Birthday��6%    67   �� *
Birthday+ 5      �� 5      "  6    .�5      ��  � ��
 �   �6L   5      5      4  .System.Windows.Controls.DataGridCheckBoxColumn  5      $ Select��6)    69   �� *
IsSelected+ 5      �� 5      "  6    .�5      ��  � ��
 �   �6L   5      5!      4  .System.Windows.Controls.DataGridComboBoxColumn  5"      $ Gender��6)   -   5        
gender��   SelectedValueBinding 5"   I   �� *Gender+	 �� Mode$	 TwoWay=�
   DisplayMemberPath
 5#   %   �� *Gender+ 5$      �� 5%      "  6    .�5&      ��  � ��
 �   �6L   5'      5*      5,      �� 5-   
   -   5         ��Name$ button��5-      $��	View Data��6!   $��122,251,639.6,251.4q�6J   
���**��$��16(�6z   $
��Bold"�6�   �� 5.   
   -   5        $ allData��5.   )   $��View All Data��6   $
��Left=�6:   $	��Top=�6V   $	��216��6n   $��44��6z   
���**��$��16(�6�   $
��Bold"�6�   $��562,251,0,0q�6�   �� 5/   
   -   5         ��Name$ listbox��5/      
�������$��16(�6:   $��Oblique$�6H   $��91,323,115.6,35.4q�6\   50      51      