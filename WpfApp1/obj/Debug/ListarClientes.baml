   M S B A M L   `   `   `  ����T  PMahApps.Metro, Version=2.0.0.0, Culture=neutral, PublicKeyToken=51482d6f650b2b3fV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls  5   	   G CServiExpress, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:ServiExpressServiExpress 5   	   !   ServiExpress.ListarClientes   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Kmah;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:ServiExpress     5   	     � WindowStartupLocation$  CenterScreen=�5   	    � 
ResizeMode$ CanMinimize=�5	   	    � Title$ ListarClientes��5   	   $	��600��6    $
��1000��6-   
�������.��5      � .+�5   
   �� $��Listado de clientes��6   $
��Left=�6.   $��
356,22,0,0q�6I   $	��Top=�6]   $	��322��6u   
��� � �$��36(�6�   $
��Bold"�6�   �� 5   
   -   5         ��Name$ txtBuscarRut��5      $
��Left=�6(   $��34��6C   $��
22,143,0,0q�6O    �� TextWrapping$
 Wrap=�6c   $	��Top=�6w   $	��219��6�    J� RenderTransformOrigin$ 0.5,0.5&�6�   
��� � �$��2q�6�   .��6  z�5      V� 5      .~�5      �� �� 5      �� 5       �� Angle$ -0.062Q�6&   T� 5      5      .��5   '   5      �� 5   
   -   5         ��Name$ btnBuscarRut��5      $��
Buscar Rut��6'   $
��Left=�6<   $��266,144,0,0q�6W   $	��Top=�6l   $	��150��6�   $��36��6�   
�������
���2�2�$��15(�6�   $��2q�6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ 
dgClientes��5      $
��Left=�5      	   
IsReadOnly	 . $	��235��6@   
   AutoGenerateColumns
 .  $��
35,220,0,0q�5      $	��Top=�6'   $	��928��6?    �� SelectedItem 5   .   ��  �� Path$ rut_cliente�   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Rut Cliente��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$	 130 6:   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6F   �� $ rut_cliente�  5      $ Nombre��6%   $	 180 65    6A   �� $ nombre�  5       $ 
Dirección��6%   $	 200 68    6D   �� $ 	direccion�  5!      $ 	Teléfono��6%   $	 130 67    6C   �� $ telefono�  5"      $ E-mail��6%   $	 150 65    6A   �� $ email�  5#      $ Convenio��6%   $	 140 67    6C   �� $ DescripcionConvenio�5%      �� 5&   
   -   5        $ btnMenuPrincipal��5&      $��Menu Principal��6+   $
��Left=�6D   $��
23,496,0,0q�6_   $	��Top=�6s   $	��253��6�   $��50��6�   $��15(�6�   
�������
���2�2�6�   �� 5'   
   -   5        $ btnSeleccionClientes��5'      $��Seleccion de Clientes��6/   $
��Left=�6O   $��355,496,0,0q�6j   $	��Top=�6   $	��286��6�   $��50��6�   $��15(�6�   
�������
���2�2�6�   �� 5(   
   -   5        $ btnLimpiarBusqueda��5(      $��Limpiar Busqueda��6-   $
��Left=�6H   $��712,492,0,0q�6c   $	��Top=�6x   $	��250��6�   $��54��6�   $��15(�6�   
�������
���2�2�6�   �� 5)   
   -   5         ��Name$ cboConvenio��5)      $
��Left=�6(   $��520,144,0,0q�6C   $	��Top=�6X   $	��182��6p   $��36��6�   $ 0.286,0.542&�6�   
��� � �$��2q�6�   �� 5*   
   -   5        $ BtnTipoConvenio��5*      $��Buscar por tipo Convenio��6*   $
��Left=�6M   $��721,144,0,0q�6h   $	��Top=�6}   $	��241��6�   $��36��6�   
���2�2�
�������$��15(�6�   �� 5+   
   $$��Imagenes/serviexpress-logo.png��6   $��802,-40,10,461q�68   5.      5/      