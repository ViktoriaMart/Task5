   M S B A M L   `   `   `  ����C  ?SushiPay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:SushiPaySushiPay  5   	       SushiPay.Window1   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:SushiPay     5   	     � Title$!  Оплата карткою��5   	   $	��400��5	   	   $	��400��6    � 
ResizeMode$ NoResize=�5
   	    � WindowStartupLocation$ CenterScreen=�5   	    � Icon$ Images/images.png��5   	   .��5      � $��10q�6    � RowDefinitions 5   
   �� 5      $��30 �6   �� 5      $��30 �6   �� 5      $��30 �6   �� 5      $��30 �6   �� 5      $��30 �6   �� 5      $��30 �6   �� 5      $
��Auto �6   .+�5   
   �� -   5        $��ForSum��5      $��1��6   
���  ��$
��Bold"�6?   $��0,0.8,-0.4,30.6q�6Q   $��2��6j   6}   �� 5   
   $
��Bold"�6   $��1��6"   $��0,30.8q�6/   $��3��6?   .��6P   )'Введіть номер картки:6g   �� 5   
   -   5        $��	numberBox��5   !    �� 	MaxLength$ 16��6   $��3��62   $	��250��6?   $��17(�6N   $��4,0.4,-4.4,31q�6�   $��2��6�   6�   �� 5   
   $��4��6   $
��Bold"�6   $��	0,0.2,0,0q�6/   .��6B   Введіть пароль:6S   G� 5   
   -   5        $��passwordBox��5   5    G� PasswordChar$ *��6    G� 	MaxLength$ 4��6'   $��5��6H   $��17(�6U   $	��250��6c   $��4,0,-4.4,0.2q�6�   6�   �� 5   
   -   5        $��MessagesLabel��5      $��6��6%   $��SemiBold"�62   $��Center=�6H   $��Center=�6e   $��
0,0,0,39.6q�6�   $	��374��6�   $��38��6�   ��5      �� 5      -   5        $��Messages��5       �� TextAlignment$ Center=�6,   $	��370��6C   $��20(�6O   $
��Wrap=�6]   6t   5       � 5!   
   $��6��6   $��Right=�6!   $��0,124.8,10,-43q�6=   	 J� RenderTransformOrigin$	 
0.342,0.42&�6U   $	��158��6x   .+�5"      �� -   5        
 �� 	IsDefault
 . $��60��5"   &   $��0,0,20,0q�64   $��15(�6F   .��6q   OK6u   �� 5#      -   5         �� IsCancel . $��60��5#   %   $��15(�63   .��6b   Скасувати6m   5$      5&      5(      