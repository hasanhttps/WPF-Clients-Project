   M S B A M L   `   `   `  ����R  NWPF Clients Application, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM+clr-namespace:WPF_Clients_Application.ViewsWPF_Clients_Application.Views  5   	   5    /WPF_Clients_Application.Views.ClientProfileView   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Z VFontAwesome.WPF, Version=4.7.0.37774, Culture=neutral, PublicKeyToken=0758b07a11a4f466-fa$http://schemas.fontawesome.io/icons/  5   	   7local+clr-namespace:WPF_Clients_Application.Views  5   	   -   5          � Title$  Clients��5	   	   $	��720��6   $	��365��6&    � 
ResizeMode$ NoResize=�62    � WindowStartupLocation$ CenterScreen=�6H   ���#F4F8FB.��5
      �  � RowDefinitions 5   
   �� 5      $��5* �6   �� 5      $	��83* �6   .+�5   
   � $��0��6   
������� � ColumnDefinitions 5      �� 5      �� 5      .+�5      �� $��0��6      clientsLogo#��[  6$   $��51��6J   $
��Left=�6X   $��10q�6s   �� 5      -   5        $��1��5      $��17(�6(   $
��home��66   $��Right=�6B   $��10q�6^   ���#01133D6   5      � 5   
   $��1��6   .+�5      �� .+�5      �� $��
12 20 12 0q�6    �� Orientation$ 
Horizontal=�61   .+�5      �� $��17(�6    $
��Bold"�6.   ���#01133D��6@   �� *SelectedClient.Name+6e   �� 5      $��17(�6    $
��Bold"�6.   $�� ��6@   ���#01133D6I   �� 5       $��17(�6    $
��Bold"�6.   ���#01133D��6@   �� *SelectedClient.Surname+6h   "  FontAwesome.WPF.ImageAwesome  5!      -   5           Icon$ Pencil=�5!   &   $��Right=�64   $��
165 0 12 0q�6P   $��15��6d   $��18��6o   6{   5"      �� 5#      $��
12 13 12 0q�6   $ 
Horizontal=�61   .+�5$        $ Building=�6&   $��15��66   $��18��6A   �� 5%      $��15(�6    $��9 0 0 0q�6.   ���#01133D��6?   �� *SelectedClient.Company+6g     5&      $��85 0 0 0q�6&   $ Phone=�68   $��15��6E   $��18��6P   �� 5'      $��15(�6    $��6 0 0 0q�6.   ���#01133D��6?   �� *SelectedClient.PhoneNumber+6k   5(      �� 5*      $��	12 18 0 0q�6   $ 
Horizontal=�60   .+�5+      �� $��15(�6    $��
Came from:��6.   ���#01133D6@     5,      $��9 0 0 0q�6&   $��15��6]   $��18��6h    67   �� *SelectedClient.Place+6h   �� 5-      $��15(�6    $��45 0 0 0q�6.   $��Registered:��6@   �� 5.      $��15(�6    $	��6 0q�6.   ���#01133D��6;   �� *SelectedClient.RegisterDate+6h   5/      �� 51      -   5        $��
OrdersView��51      $
��Auto=�6-   $��Hidden=�6]   
������ $	��500��6�   $��	0 14 0 20q�6�   
������ ��6�   �� *SelectedClient.Orders+��52      �� 53      .R�54      �� 
�������$��10 7.5 10 7.5q�68   $	��318��6O   $	��115��6[    �� CornerRadius$ 3��6h   ._�55   "   �� .+�56   &   �� $ 
Horizontal=�61   .+�57   *   �� $��9 9 0 0q�64   $��17(�6E   $
��Bold"�6S   ��6e   �� *Name+  58   .   $��93 0 0 0q�6>   $ Pencil=�6P   $��15��6^   $��18��6i    J� InputBindings 59   2   d� 5:   6   	 d� MouseAction$	 	LeftClicke�6C   
 �� CommandParameter
 6[   ��  �� Command 6x   �� *!DataContext.NewOrderEditCommand+ �� RelativeSource ��  �� AncestorType" ��5<   /   �� 5=   .   $��8 0 0 0q�65   $��8��6F   $��8��6Q   $ 8��6[   ��6l   �� *status+5>   '   �� 5?   &   $��9 14 0 0q�61   $ 
Horizontal=�6C   .+�5@   *   �� $��15(�64   $��Order quantity:��6B   �� 5A   *   $��15(�64   $��3 0 3 0q�6B   ��6S   �� *OrderQuantity+�� 5B   *   $��15(�64   $	��pcs��6B   5C   '   �� 5E   &   $��9 5 0 0q�61   $ 
Horizontal=�6B   .+�5F   *   �� $��15(�64   $��Delivery day:��6B   �� 5G   *   $��15(�64   $	��3 0q�6B   ��6O   �� *DeliveryDay+5H   '   �� 5J   &   $��9 5 0 0q�61   $ 
Horizontal=�6B   .+�5K   *   �� $��15(�64   $��
Order day:��6B   �� 5L   *   $��15(�64   $	��3 0q�6B   ��6O   �� *
OrderDay+5M   '   5N   #   5O      5P      5R      5S      �� 5U      $��280 530 12 47q�6   $��54��6,   $��58��67   ��6C   �� *NewOrderCommand+��5V      �� 5W      .+�5X      �� $��17(�6$   $��Center=�62   $��+��6O   �� 5Y      $��17(�6$   $	��new��62   5Z      5\      �� 5]      $3��-Proudly created by Hasan Abdullazade in 2023.��6   $��Bottom=�6M   $��Center=�6h   ���#CBD2DB6�   5^      5_      5`      