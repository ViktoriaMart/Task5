   M S B A M L   `   `   `  ����C  ?SushiPay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:SushiPaySushiPay  5   	   O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089I2clr-namespace:System.Collections;assembly=mscorlibSystem.Collections 5   	       SushiPay.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:SushiPay     5   	   Bcol2clr-namespace:System.Collections;assembly=mscorlib     5   	     � Title$"  Касир суші-бару��5
   	   $	��726��5   	   $
��1024��6    � WindowStartupLocation$ CenterScreen=�5   	    � 
ResizeMode$ NoResize=�5   	    � WindowState$ 	Maximized=�6    � Icon$ Images/images.png��5   	   .��5      � 
�������.+�5   
   �� -   5        $��prodList��5      $��17(�6#   $	��640��61   $	��800��6@   $	��Top=�6P   $
��Left=�6h   
�������
������� �� View 5      �� 5      .P�5      ��  �� Width$ 80��6U    �� DisplayMemberBinding 6%   ��  �� Path$ 	ProductId�.��6`   Код6e   �� 5      $	 300��6W    6%   �� $ ProductName�.��6c   Назва продукту6s   �� 5      $	 100��6[    6%   �� $ ProductQuantity�.��6g   Кількість6r   �� 5      $	 100��6X    6%   �� $ ProductPrice�.��6d   
Ціна6j   5      5      � 5   
   	 � Orientation$	 Vertical=�6   $��Right=�6+   $��0,0,0.6,0.8q�6H   $	��301��6]   .+�5      �� -   5        
�������$+��%Отримати замовлення��5   ,   $	��300��6J   $��60��6V   $��15(�6{   �� 5      -   5        
�������$)��#Оплатити кредиткою��5   ,   $	��300��6I   $��60��6U   $��15(�6   �� 5      -   5        
�������$'��!Оплатити готівкою��5   ,   $	��300��6H   $��60��6T   $��15(�6|   �� 5       -   5        $��MessagesLabel��5       $��Bottom=�6*   $��SemiBold"�6E   $��Right=�6[   $��15(�6w   ��5!      �� 5"      -   5        $��Messages��5"       
 �� TextAlignment$
 Center=�60   $	��300��6G   $��20(�6S   $��95��6a   $
��Wrap=�6p   6�   5$      5%      �� 5&   
   -   5        $��LeastSum��5&      $��Bottom=�6$   $��25(�6?   $
��Bold"�6M   
���  ��$��	20 0 0 15q�6s   Загальна сума:6�   5(      5)      