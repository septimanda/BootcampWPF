   M S B A M L   `   `   `  ����F  BBootcampWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:BootcampWPF.UserControlsBootcampWPF.UserControls  5      2    ,BootcampWPF.UserControls.SupplierUserControl   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      8local&clr-namespace:BootcampWPF.UserControls     5      V RMaterialDesignThemes.Wpf, Version=2.5.1.1345, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      -   5        .��5      � .+�5   
   ?  9MaterialDesignThemes.Wpf.Transitions.TransitioningContent  -   5           Name$  Slide_TransitionContent��5   .   C  =MaterialDesignThemes.Wpf.Transitions.TransitioningContentBase   OpeningEffect 6O   D  >MaterialDesignThemes.Wpf.Transitions.TransitionEffectExtension  *SlideInFromRight+   Duration$ 0:0:0.2X�.��5      ��  �� Orientation$ Vertical=�6   .+�5      �� .+�5      �� -   5         ��Name$ 	textBlock��5       $
��Wrap=�63   $��SUPPLIER��6G    �� TextAlignment$ Center=�6W   $	��Top=�6n   $��Palatino Linotype)�6�   $��25(�6�   $��25q�6�   &   System.Windows.Controls.DataGrid  5      -   5          Name$ Supplier_DataGrid��5      $	��Top=�67   $	��168��6O   $	��450��6\      AutoGenerateColumns .  
������� J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5      	   Color$	 	#FFE8E8E8��6+   
   Columns
 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6-   1  +System.Windows.Controls.DataGridBoundColumn   Binding 69   �� *Id+  5      $ Supplier Name��6-      Width5	  /System.Windows.Controls.DataGridLengthConverter$ *	 6]    6D   �� *Name+6]      ColumnHeaderStyle 5      �� 5       �� 
TargetType=
  7System.Windows.Controls.Primitives.DataGridColumnHeader" 
 6    .�5      ��  �� Property � �� �� Value$ Center=�6K   �� 5       � ��
 �����6;   �� 5       � ��$ 30��67   5      5       5!      �� 5"      $ 
Horizontal=�6   $��Center=�66   $
��0 40q�6S   .+�5#      �� -   5        $ 
textBlock1��5#       $
��Left=�64   $
��Wrap=�6O   $��Supplier Name : ��6c   $��Center=�6{   $��16(�6�   �� 5$      -   5         ��Name$ SupplierName_Txt��5$      $��Center=�68   $��29��6U    �� TextWrapping$
 Wrap=�6a   $	��Top=�6u   $	��295��6�   $��Center=�6�   $��16(�6�   �� 5%      -   5        $ SupplierId_Txt��5%      $
��Left=�66   $��23��6Q   $
 Wrap=�6]   $	��Top=�6q   $��48��6�   $y�	Collapsed=�6�   5&      �� 5'      $ 
Horizontal=�6   $��Center=�66   .+�5(      �� -   5         ��Name$ SaveSupplier_Btn��5(      $��Save Supplier��67   $
��Left=�6O   $	��Top=�6j   $	��130��6�   $��35��6�   $��10q�6�   6�   �� 5)      -	   5        $ DeleteSupplier_Btn��5)      $��Delete Supplier��69   $
��Left=�6S   $	��Top=�6n   $	��130��6�   $��35��6�   $��10q�6�   6�   5*      5+      5-      5.      5/      