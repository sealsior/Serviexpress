   M S B A M L   `   `   `  ����T  PMahApps.Metro, Version=2.0.0.0, Culture=neutral, PublicKeyToken=51482d6f650b2b3fV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls  5   	   G CServiExpress, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:ServiExpressServiExpress 5   	       ServiExpress.AdminClientes   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Kmah;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:ServiExpress     5   	     � WindowStartupLocation$  CenterScreen=�5	   	    � 
ResizeMode$ CanMinimize=�5
   	    � Title$ AdminCliente��5   	   $	��600��6   $
��1080��6+   
�������.��5      �  � RowDefinitions 5   
   �� 5      $
��337* �6   �� 5      $
��132* �6   .+�5   
   �� -   5         ��Name$ 
lbl_titulo��5      $ ��Administracion de Clientes��6$   $
��Left=�6I   $��
275,14,0,0q�6d   $	��Top=�6x   $��30(�6�   $
��Bold"�6�   
��� � �6�   �� 5   
   -   5        $ 	lblNombre��5      $��Rut :*��6#   $
��Left=�64   $��	28,94,0,0q�6O   $	��Top=�6b   $��18(�6z   
��� � �$��54��6�   $
��Bold"�6�   �� 5   
   -   5        $ 	lnlNombre��5      $��Nombre :��6#   $
��Left=�66   $��
28,159,0,0q�6Q   $	��Top=�6e   $��18(�6}   
��� � �$
��Bold"�6�   �� 5   
   -   5        $ lblMail��5      $��Mail :��6!   $
��Left=�62   $��
28,222,0,0q�6M   $	��Top=�6a   $��18(�6y   
��� � �$
��Bold"�6�   �� 5   
   -   5        $ lblTelefono��5      $��Teléfono :��6%   $
��Left=�6:   $��
382,94,0,0q�6U   $	��Top=�6i   $��18(�6�   
��� � �$
��Bold"�6�   �� 5   
   -   5        $ lblDireccion��5      $��Dirección :��6&   $
��Left=�6<   $��382,165,0,0q�6W   $	��Top=�6l   $��18(�6�   
��� � �$
��Bold"�6�   �� 5   
   -   5         ��Name$ txtRut��5      $
��Left=�6"   $��26��6=   $��145,102,0,0q�6I    �� TextWrapping$
 Wrap=�6^   $	��Top=�6r   $	��174��6�   
��� � �$��2q�6�   �� 5   
   -   5        $ 	txtNombre��5      $
��Left=�6%   $��26��6@   $��145,167,0,0q�6L   $
 Wrap=�6a   $	��Top=�6u   $	��174��6�   
��� � �$��2q�6�   �� 5   
   -	   5        $ txtMail��5      $
��Left=�6#   $��26��6>   $��145,230,0,0q�6J   $
 Wrap=�6_   $	��Top=�6s   $	��174��6�   
��� � �$��2q�6�   �� 5   
   -
   5        $ txtTelefono��5      $
��Left=�6'   $��26��6B   $��488,102,0,0q�6N   $
 Wrap=�6c   $	��Top=�6w   $	��174��6�   
��� � �$��2q�6�   �� 5   
   -   5        $ txtDireccion��5      $
��Left=�6(   $��26��6C   $��488,173,0,0q�6O   $
 Wrap=�6d   $	��Top=�6x   $	��174��6�   
��� � �$��2q�6�    J� RenderTransformOrigin$ 0.595,-1.087&�6�   �� 5   
   -   5         ��Name$ 
bntLimpiar��5      $��Limpiar��6%   $
��Left=�67   $��670,292,0,0q�6R   $	��Top=�6g   $	��188��6   $��48��6�   $��18(�6�   
��� � �$��2q�6�   
���2�2�
�������6�   �� 5   
   -   5        $ btnMenuPrincipal��5      $��Menu Principal��6+   $
��Left=�6D   $��886,292,0,0q�6_   $	��Top=�6t   $	��160��6�   
���2�2�$��48��6�   $��18(�6�   
�������$ 0.044,5.047&�6�   �� 5   
   -   5        $ btnEliminarCli��5      $��Eliminar Cliente��6)   $
��Left=�6D   $��225,292,0,0q�6_   $	��Top=�6t   $	��188��6�   $��48��6�   
���2�2�
�������$��18(�6�   6�   �� 5   
   -   5        $ btnModificarCli��5      $��Modificar Cliente��6*   $
��Left=�6F   $��444,292,0,0q�6a   $	��Top=�6v   $	��192��6�   $��48��6�   
���2�2�
�������$��18(�6�   6�   �� 5    
   -   5        $ btnBuscarCli��5       $��Buscar Cliente ��6'   $
��Left=�6A   $��742,162,0,0q�6\   $	��Top=�6q   $	��160��6�   $ 2,0.525&�6�   $��48��6�   
���2�2�
�������$��18(�6�   6�   �� 5!   
   -   5        $ 
BtnGuardar��5!      $��Guardar��6%   $
��Left=�67   $��
28,292,0,0q�6R   $	��Top=�6f   $	��160��6~   $��48��6�   
���2�2�
�������$��18(�6�   6�   &   System.Windows.Controls.DataGrid  5"   
   -   5        	  Name$	 
gdClientes��5"      $
��Left=�5#      
   
IsReadOnly
 . $	��235��6@      AutoGenerateColumns .  $��	0,351,0,0q�5%      $	��Top=�6&   $	��928��6>   $��1��6J    �� SelectedItem 5$   [   ��  �� Path$ rut_cliente�   Columns 5&      0  *System.Windows.Controls.DataGridTextColumn  5'      ,  &System.Windows.Controls.DataGridColumn   Header$ Rut Cliente��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$	 130 6:   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6F   �� $ rut_cliente�  5(      $ Nombre��6%   $	 180 65    6A   �� $ nombre�  5)      $ 
Dirección��6%   $	 200 68    6D   �� $ 	direccion�  5*      $ 	Teléfono��6%   $	 130 67    6C   �� $ telefono�  5+      $ E-mail��6%   $	 150 65    6A   �� $ email�  5,      $ Convenio��6%   $	 140 67    6C   �� $ DescripcionConvenio�5.      �� 5/   
   -   5        $ lblConvenio��5/      $��Convenio��6%   $
��Left=�68   $��382,228,0,0q�6S   $	��Top=�6h   $��93��6�   
��� � �$��18(�6�   $
��Bold"�6�   �� 50   
   -   5         ��Name$ cboConvenio��50      $
��Left=�6(   $��488,230,0,0q�6C   $	��Top=�6X   $	��174��6p   
��� � �$��2q�6�   6�   )   #MahApps.Metro.Controls.ToggleSwitch  51   
   -   5          Name$ 
txtEditar1��51      $��Editar��6/   $
��Left=�6?   $��61��6Z   $��	10,10,0,0q�6f   $	��Top=�6y   $	��121��6�   
��� � �
��� � �6�   �� 52   
   $$��Imagenes/serviexpress-logo.png��6   $��882,-43,10,304q�68   54      55      