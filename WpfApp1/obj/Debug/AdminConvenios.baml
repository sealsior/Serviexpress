   M S B A M L   `   `   `  ����T  PMahApps.Metro, Version=2.0.0.0, Culture=neutral, PublicKeyToken=51482d6f650b2b3fV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls  5   	   G CServiExpress, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:ServiExpressServiExpress 5   	   K GBibliotecaClases, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM8clr-namespace:BibliotecaClases;assembly=BibliotecaClasesBibliotecaClases 5	   	   !   ServiExpress.AdminConvenios   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Kmah;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro     5   	   ;Controls,http://metro.mahapps.com/winfx/xaml/controls   5   	   Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006   5   	   &localclr-namespace:ServiExpress   5   	   OBibliotecaClases8clr-namespace:BibliotecaClases;assembly=BibliotecaClases   5	   	     � WindowStartupLocation$  CenterScreen=�5   	    � 
ResizeMode$ CanMinimize=�5   	    � Title$! Administracion de servicios��5   	   $��641.5��6-   $
��1000��6<   $
��Bold"�6I   .��5      � 
������� � ColumnDefinitions 5   
   �� 5      $	��33* �6   �� 5      $
��761* �6   .+�5   
   �� $��Descripción:��6   $
��Left=�6'   $��18(�6B   $��
28,146,0,0q�6P   $	��Top=�6d   
��� � �$
��Bold"�6�   $��1��6�   �� 5   
   $��
Descuento:��6   $
��Left=�6%   $��18(�6@   
��� � �$��
33,224,0,0q�6a   $	��Top=�6u   $
��Bold"�6�    J� RenderTransformOrigin$ -0.479,0.531&�6�   $��1��6�   �� 5   
   $"��Administración de Convenios��6   $
��Left=�66   $��
271,-1,0,0q�6Q   $	��Top=�6e   $��30(�6}   $
��Bold"�6�   
��� � �$��1��6�   �� 5   
   $
��Left=�6   $��0��6-   $��186,206,0,0q�68   $	��Top=�6M   $��13��6e   $��1��6p   �� 5   
   -   5         ��Name$ txtDescuento��5      *   $MahApps.Metro.Controls.TextBoxHelper   ClearTextButton . $
��Left=�6V   
��� � �$��23��6�   $��137,232,0,0q�6�    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�   $	��208��6�   $��1��6�   �� 5   
   -   5         ��Name$ btnRegistrar��5      $��	Registrar��6'   $
��Left=�6;   $��298,281,0,0q�6V   $	��Top=�6k   $	��105��6�   $��38��6�   $
��Bold"�6�   $��15(�6�   
�������
���2�2�$��1��6�   6�   �� 5   
   -   5        $ 	btnVolver��5      $��Menu Principal��6$   
���2�2�$��15(�6T   
�������$
��Left=�6u   $��789,282,0,0q�6�   $	��Top=�6�   $	��140��6�   $��37��6�   $
��Bold"�6�   $ 0.35,0.5&�6�   $��1��6	  6  �� 5   
   -   5        $ txtDescripcion��5       . $
��Left=�6X   
��� � �$��55��6�   $��142.4,151,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��288��6�   $��1��6�   �� 5   
   -   5        $ 
btnLimpiar��5      $��Limpiar��6%   
���2�2�$��15(�6O   
�������$
��Left=�6p   $��665,282,0,0q�6�   $	��Top=�6�   $	��106��6�   $��37��6�   $��1��6�   $ 0.084,0.486&�6�   6  �� 5   
   $	��ID:��6   $��18(�6   $
��Left=�6,   $��103,101,0,0q�6G   $	��Top=�6\   
��� � �$��1��6�   �� 5   
   -   5        $ txtIdConvenio��5       . $
��Left=�6W   
��� � �$��23��6�   $��142,109,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��203��6�   $��1��6�   {�.  6�   &   System.Windows.Controls.DataGrid  5   
   -   5        	  Name$	 dgConvenios��5      $
��Left=�5      
   
IsReadOnly
 . $	��235��6@      AutoGenerateColumns .  $��	0,351,0,0q�5!      $	��Top=�6&   $	��928��6>   $��1��6J    �� SelectedItem 5    .   ��  �� Path$ id_convenio�   Columns 5"      0  *System.Windows.Controls.DataGridTextColumn  5#      ,  &System.Windows.Controls.DataGridColumn   Header$ ID Convenio��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$	 100 6:   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6F   �� $ id_convenio�  5$      $ Descripción��6%   $	 150 6:    6F   �� $ descripcion�  5%      $ % Descuento��6%   $	 110 6:    6F   �� $ 	descuento�5'      �� 5(   
   -   5        $ btnBuscarId��5(      $��Buscar��6&   
���2�2�$��14(�6N   
�������$
��Left=�6o   $��352,105,0,0q�6�   $	��Top=�6�   $��75��6�   $ 0.336,0.552&�6�   $��1��6�   6�   �� 5)   
   -	   5        $ btnActualizar��5)      $��
Actualizar��6(   $
��Left=�6=   $��420,281,0,0q�6X   $	��Top=�6m   $	��105��6�   $��38��6�   $
��Bold"�6�   $��15(�6�   
�������
���2�2�$��1��6�   6�   �� 5*   
   -
   5        $ btnEliminar��5*      $��Eliminar��6&   $
��Left=�69   $��541,282,0,0q�6T   $	��Top=�6i   $	��105��6�   $��38��6�   $
��Bold"�6�   $��15(�6�   
�������
���2�2�$��1��6�   6�   �� 5+   
   $(��"*Todos los campos son obligatorios��6   $��1��6=   $
��Left=�6M   $��
21,289,0,0q�6h   $	��Top=�6|   
���  ��6�   �� 5,   
   $$��Imagenes/serviexpress-logo.png��6   $��761,-43,10,506q�68   $��1��6P   )   #MahApps.Metro.Controls.ToggleSwitch  5-   
   -   5          Name$ tsEditar��5-      $��1��6-   $��Editar��6=   $
��Left=�6M   $	��100��6h   $��	33,35,0,0q�6u   $	��Top=�6�   $	��100��6�      
OffContent$ No��6�      	OnContent$ Si��6�   
��� � �
��� � �6�   �� 5.   
   $��%��6   $
��Left=�6   $��18(�67   $��350,224,0,0q�6E   $	��Top=�6Z   
��� � �$
��Bold"�6�   $��1��6�   51      52      