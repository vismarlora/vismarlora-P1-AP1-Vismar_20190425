   M S B A M L   `   `   `  ����Q  MP1-AP1-Vismar_20190425, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullY1clr-namespace:P1_AP1_Vismar_20190425.UI.Consultas#P1_AP1_Vismar_20190425.UI.Consultas  5   	   2    ,P1_AP1_Vismar_20190425.UI.Consultas.cAportes   5   	   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Clocal1clr-namespace:P1_AP1_Vismar_20190425.UI.Consultas     5   	     � Title$  Consulta de Aportes��5   	   $	��400��6%   $	��550��62   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $
��692* �6   �� 5      $
��109* �6   .+�5   
   ��  �� Orientation$ Vertical=�6   $��
10,10,10,0q�6,   $��2��6@    J� RenderTransformOrigin$ 0.561,0.447&�6T   .+�5      �� $ 
Horizontal=�6   $��58��62   .+�5      �� .+�5      �� $��Desde:��6   (  "System.Windows.Controls.DatePicker  5      -   5          Name$ DesdeDatePicker��5   !   $��85��6:   5      �� 5      $ Vertical=�6   $	��5,0q�64   .+�5      �� $��Hasta:��6     5      -   5        $ HastaDatePicker��5   !   $��85��6:   5      �� 5      .+�5      �� $ Vertical=�6!   $	��5,0q�68   .+�5      �� $��Filtro:��6    �� 5      -   5         ��Name$ FiltroComboBox��5   #   $	��100��6;   .@�5      �� $��Persona��6+   �� 5       $��Concepto��6+   5!      5"      5#      �� 5%      .+�5&      �� $ Vertical=�6!   $
��5,26q�68   .+�5(      �� -   5         ��Name$ CriterioTextBox��5(   "   $	��100��6;   5*      5,      �� 5.      $ 
Horizontal=�6   $
��0,10q�66   .+�5/      �� -   5         ��Name$ BuscarButton��5/      $��10,0,0,0q�63   $��30��6E   $��80��6Q   .��50      �� $ 
Horizontal=�6%   .+�51      �� $,��&/Resources/search_locate_find_6278.png��6$   �� 52      $��Buscar��6$   $ 
0.521,0.55&�65   53      54      55      56      �� 58      $ 
Horizontal=�6   $
��Left=�62   .+�59      �� $
��Left=�6   .+�5:      &   System.Windows.Controls.DataGrid  -   5          Name$ DatosDataGrid��5:      $	��240��66   $	��489��6C   	   AutoGenerateColumns$	 False��6O   
   Columns
 5;      0  *System.Windows.Controls.DataGridTextColumn  5<      ,  &System.Windows.Controls.DataGridColumn   Header$ Aporte Id          ��61   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6N   �� *
AporteId+  5>      $ Fecha              ��61    6N   �� *Fecha+  5@      $ Persona            ��61    6N   �� *	Persona+  5B      $ Concepto           ��61    6N   �� *
Concepto+  5D      $ Monto              ��61    6N   �� *Monto+5G      5H      �� 5J      5L      5N      �� 5P      $ 
Horizontal=�6   $
��0,20q�62   .+�5Q      �� $��Conteo��6   �� 5R      -   5        $ ConteoTextBox��5R      $	��100��61   .��6=   5T      �� 5V      $��Total��6   $��	205,0,0,0q�6(   �� 5W      -   5        $ TotalTextBox��5W      $	��100��60   5X      5Y      5Z      5[      