   M S B A M L   `   `   `  ����G  CStockGestion, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:StockGestion.ViewsStockGestion.Views  5      "    StockGestion.Views.ListStock   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      2local clr-namespace:StockGestion.Views     5      b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5        N� Title$  	ListStock��5
      .��5      �  � RowDefinitions 5   
   �� 5      $	��25* �6   �� 5      $
��165* �6   .+�5   
   ��  �� Orientation$ 
Horizontal=�6   $��Center=�5      $��226,0,225,0q�5      .+�5      �� $	��250��6   $��25��5       �� CornerRadius$ 	15,0,0,15��5      $��1q�5      ���	#FF62669B
�������._�5      �� -   5         ��Name$ rechercheProd��5      $	��200��5      $��20��5      $��recherche produit��5      $��14(�5      
�������$��0q�5!      $��Center=�5"      
���������5       Z� 5$      5%      �� 5&      -   5         ��Name$ recherche_produit��5&      $��50��5'      $��25��5(         searchButton#��[  5)      .��5*      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ Search=�6*   $��20��5+   *   $��20��5,   *   5-      5.      � 5/   
   -   5         �Name$
 grid��5/      $��1��6   .+�50      &   System.Windows.Controls.DataGrid  -   5          Name$ dataGrid��50      $
��Left=�51      $��10,0,0,0q�52      $	��Top=�53      $	��734��54      
������ $	��471��56      ���	#FF62669B	 � 	Resources	 58      =  7System.Windows.Controls.Primitives.DataGridColumnHeader
 �� 
TargetType �� Property �� Value �� 
TargetType*  $System.Windows.Controls.DataGridCell��%p  '        '  �    �� 59      "
  6   .�5:      ��  � �� �	#FF62669B67   �� 5;       � ��$ SemiBold"�67   �� 5>       � ��$ 30��63   �� 5?       � ��$ 6q�64   �� 5@       � �� 5A      �� 5B   "   "  62   .R�5C   &   �� #��z��6-   $ 5,5,0,0��6W   $��2q�5D   G   ���	#FF62669B._�5F   *   �� $��Center=�6;   $��Center=�6X   5G   '   5H   #   5J      5K      �� 5L      "
  6   .�5M      ��  � ��
 �   �67   �� 5N       � ��$ Center=�6@   �� 5O       � ��$ Center=�6>   �� 5P       � ��$ 30��63   5Q      5R         Columns 5T      0  *System.Windows.Controls.DataGridTextColumn  5U      ,  &System.Windows.Controls.DataGridColumn   Header$ Id Produits��6)      Width5  /System.Windows.Controls.DataGridLengthConverter$	 100 6U   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6>   �� *Id+6U     5V      $ Produits��6)   $	 150 6W    6;   �� *	Libelle+6W     5W      $ 
Quantités��6)   $	 150 6Z    6=   �� *
Quantite+6Z     5X      $ Prix Unitaires (Ar)��6)   $	 150 6g    6F   �� *PrixUnitaire+6g     5Y      $ Fournisseurs��6)   $ * 6_    6?   �� *Fournisseur+6_   5^      5_      5`      5a      