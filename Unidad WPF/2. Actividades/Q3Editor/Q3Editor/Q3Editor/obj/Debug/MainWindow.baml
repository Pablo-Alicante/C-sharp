   M S B A M L   `   `   `  ����C  ?Q3Editor, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:Q3EditorQ3Editor  5   	       Q3Editor.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:Q3Editor     5   	   -   5          �Name$  VentanaPrincipal��5   	    � Title$ Q3Editor��5   	   $	��450��6   $	��800��6'   .��5	      � .+�5
   
   o� -   5         o�Name$ 
mPrincipal��5
      $��	0,0,0,387q�6#   ��. .@�5      m� -   5         m�Name$ mArchivo��5      $��_Achivo��6)   $��24��6:   $��52��6F   .@�5      m� -   5        $ mArchivoNuevo��5      $��_Nuevo��62   $��24��6B    � Cursor$
 Hand��6N    m� InputGestureText$ Ctrl+N��6x   �� 5      m� 5      -   5        $ mArchivoAbrir��5      $��	A_brir...��62   $��24��6E   $
 Hand��6Q   $ Ctrl+O��6{   �� 5      m� 5      -   5        $ mArchivoGuardar��5      $��_Guardar��64   $��24��6F   $
 Hand��6R   $ Ctrl+S��6~   m� 5      -   5        $ mArchivoGuardarComo��5      $��G_uardar como...��68   $��24��6R   $
 Hand��6^   6l   �� 5      m� 5      -   5        $ mArchivoImprimir��5      $��_Imprimir...��65   $��24��6K   $
 Hand��6W   $ Ctrl+P��6e   �� 5      m� 5      -	   5        $ mArchivoSalir��5      $��_Salir��62   $��24��6B   $
 Hand��6N   $ Alt+F4��6x   5      m� 5      -
   5        $ mEditar��5      $��Edi_tar��6(   $��24��69   $��45��6E   .@�5      m� -   5        $ mEditarCortar��5      $��Cor_tar��62   $��24��6C   $
 Hand��6O   $ Ctrl+X��6]   m� 5      -   5        $ mEditarCopiar��5      $��_Copiar��62   $��24��6C   $
 Hand��6O   $ Ctrl+C��6]   6w   m� 5      -   5        $ mEditarPegar��5      $��Pe_gar��61   $��24��6A   $
 Hand��6M   $ Ctrl+V��6[   6u   5      m� 5      -   5        $ mFuente��5      $��_Fuente��6(   $��24��69   $��52��6E   .@�5      m� -   5        $ mFuenteNegrita��5      $��_Negrita��63   $��24��6E   $ Ctrl+B��6Q   6k   m� 5      -   5        $ mFuenteCursiva��5      $��_Cursiva��63   $��24��6E   $ Ctrl+K��6Q   6k   m� 5      -   5        $ mFuenteSubrayado��5      $��
_Subrayado��65   $��24��6I   $ Ctrl+U��6U   6o   �� 5       $��1��6   m� 5!      -   5        $ mFuenteAumentar��5!      $��_Aumentar tamaño��64   $��24��6N   $ Ctrl++��6Z   6t   m� 5"      -   5        $ mFuenteDisminuir��5"      $��_Disminuir tamaño��65   $��24��6P   $ Ctrl+-��6\   6v   �� 5#      $��1��6   m� 5$      -   5        $ mFuenteFuentes��5$      $��_Fuentes...��63   $��24��6H   6T   5%      5&      �� 5'   
   $��24��6   $��Bottom=�6    .@�5(      �� -   5         ��Name$ panelEstado��5(      $��Guardado��61   $��80��6D   �� 5)      -   5        $ panelNombre��5)      $��<Sin nombre>��61   
�������$��1,0,0,0q�5*   /   5+      �� 5,   
   -   5         ��Name$ txtTexto��5,      $��	0,32,0,24q�6$    �� TextWrapping$
 Wrap=�67   	 �� 
AcceptsTab	 . $��16(�6]   $��0q�6k   
 �� TextDecorations
 6   Z� 6�   5-      5.      