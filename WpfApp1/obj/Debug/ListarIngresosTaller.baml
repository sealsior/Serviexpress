   M S B A M L   `   `   `  ����T  PMahApps.Metro, Version=2.0.0.0, Culture=neutral, PublicKeyToken=51482d6f650b2b3fV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls  5   	   G CServiExpress, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:ServiExpressServiExpress 5   	   '   !ServiExpress.ListarIngresosTaller   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Kmah;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:ServiExpress     5   	     � WindowStartupLocation$  CenterScreen=�5	   	    � 
ResizeMode$ CanMinimize=�5
   	    � Title$ ListarIngresosTaller��5   	   $	��500��6&   $��1000   ��63   .��5      � 
������� � ColumnDefinitions 5   
   �� 5      $
��179* �6   �� 5      $	��69* �6   .+�5   
   �� $��
Fabricante��6   $��18(�6%   $
��Left=�63   
��� � �$��	26,49,0,0q�6b   $	��Top=�6u   $
��Bold"�6�    J� RenderTransformOrigin$ 0.547,0.212&�6�   �� 5   
   $��Tipo servicio��6   $��18(�6(   $
��Left=�66   
��� � �$��	26,90,0,0q�6d   $	��Top=�6w   $
��Bold"�6�   $ 0.547,0.212&�6�   �� 5   
   $��Rut cliente:��6   $��18(�6'   $
��Left=�65   
��� � �$��
462,90,0,0q�6c   $	��Top=�6w   $
��Bold"�6�   $ 0.211,0.462&�6�   �� 5   
   -   5         ��Name$ btnFabricante��5      $��Buscar��6(   
���2�2�$��14(�6P   
�������$
��Left=�6q   $��
364,49,0,0q�6�   $	��Top=�6�   $��76��6�   $
��Bold"�6�   6�   �� 5   
   -   5        $ 
btnLimpiar��5      $��Limpiar��6%   
���2�2�$��18(�6N   
�������$
��Left=�6o   $��611,402,0,0q�6�   $	��Top=�6�   $	��122��6�   $��50��6�   $
��Bold"�6�   $��2��6�   �� 5   
   -   5        $ btnBuscarServicio��5      $��Buscar��6,   
���2�2�$��14(�6T   
�������$
��Left=�6u   $��
364,93,0,0q�6�   $	��Top=�6�   $��76��6�   $
��Bold"�6�   $ 
0.36,0.251&�6�   6�   �� 5   
   -   5        $ btnBuscarCliente��5      $��Buscar��6+   
���2�2�$��14(�6S   
�������$
��Left=�6t   $��	50,90,0,0q�6�   $	��Top=�6�   $��76��6�   $
��Bold"�6�   $��1��6�   6�   �� 5   
   -   5        $ 	btnVolver��5      $��Menu Principal��6$   
���2�2�$��18(�6T   
�������$
��Left=�6u   $��
42,402,0,0q�6�   $	��Top=�6�   $	��170��6�   $��50��6�   $
��Bold"�6�   $��1��6�   �� 5   
   -   5        $ btnIngresarTaller��5      $��Gestión Ingresos��6,   
���2�2�$��18(�6^   
�������$
��Left=�6   $��385,402,0,0q�6�   $	��Top=�6�   $	��193��6�   $��50     ��6�   $
��Bold"�6�   6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dgListadoIngresos��5      $
��Left=�5         
IsReadOnly . $	��235��6@      AutoGenerateColumns .  $��
32,147,0,0q�5      $	��Top=�6'   $	��928��6?   $��2��6K   	 �� SelectedItem	 5   .   �� 
 �� Path$
 num_ingreso�   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5       ,  &System.Windows.Controls.DataGridColumn   Header$ 
ID Ingreso��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ 90 69   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6D   �� $
 num_ingreso�  5!      $ Patente��6%   $ 90 66    6A   �� $
 patente�  5"      $ 
Fabricante��6%   $	 100 69    6E   �� $
 Nombrefabricante�  5#      $ Modelo��6%   $	 100 65    6A   �� $
 modelo�  5$      $
 Año��6%   $ 50 62    6=   �� $

 anno�  5%      $ Rut Cliente��6%   $	 100 6:    6F   �� $
 rut_cliente�  5&      $ Nombre Cliente��6%   $	 130 6=    6I   �� $
 Nombre�  5'      $ ID Servicio��6%   $ 90 6:    6E   �� $
 id_servicio�  5(      $ Servicio��6%   $	 190 67    6C   �� $
 Descripcion�5*      �� 5+   
   -   5         ��Name$ cboServicios��5+      
��� � �$
��Left=�6=   $��
150,97,0,0q�6X   $	��Top=�6l   $	��194��6�   �� 5,   
   $$��Imagenes/serviexpress-logo.png��6   $��86,-34,10,355q�68   $��1��6O   �� 5-   
   -	   5        $ cboFabricante��5-      $
��Left=�6*   $��
150,57,0,0q�6E   $	��Top=�6Y   $	��194��6q   �� 5.   
   -
   5        $ 
cboCliente��5.      $
��Left=�6'   $��
588,93,0,0q�6B   $	��Top=�6V   $	��174��6n   $��2��6z   �� 5/   
   $"��Listado de ingresos a taller��6   $
��Left=�67   $��	298,3,0,0q�6R   $	��Top=�6e   $��27(�6}   $
��Bold"�6�   
��� � �6�   51      52      