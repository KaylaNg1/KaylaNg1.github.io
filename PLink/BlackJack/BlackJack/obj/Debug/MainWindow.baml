   M S B A M L   `   `   `  ����D  @BlackJack, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:BlackJack	BlackJack  5   	       BlackJack.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:BlackJack     5   	     � Title$  
MainWindow��5   	   $	��750��6   $
��1000��6)   .��5	      � -   5         �Name$
 Home��5	      $
��1000��6   $	��750��6&   ��5
   
   �� 5       �� ImageSource$ Images/Table.jpg��6   .+�5   
   �� -   5         ��Name$ Title��5      $��	BlackJack��6   $
��Left=�63   $��368,175,0,0q�6N   $	��Top=�6c   $��95��6{   $	��248��6�   $
��Bold"�6�   $��48(�6�   $��Segoe Print)�6�   ���	#FFFF9B9B���	#FFFF0F0F J� OpacityMask �	#FFBB2D2D
������� J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5      5      �� 5   
   -   5         ��Name$ StartBtn��5      $��Start��6#   $
��Left=�63   $	��Top=�6N   $	��213��6f   $��113,350,0,0q�6r   $��54��6�   ���	#FFFF1143$��Segoe Print)�6�   $��24(�6�   $
��Bold"�6�   6�   �� 5   
   -   5        $ HelpBtn��5      $
��Help��6"   $
��Left=�61   $	��Top=�6L   $	��213��6d   $��403,350,0,0q�6p   $��54��6�   ���	#FFFF1143$��Segoe Print)�6�   $��24(�6�   $
��Bold"�6�   6�   �� 5   
   -   5        $ Exitbtn��5      $
��Exit��6"   $
��Left=�61   $	��Top=�6L   $	��213��6d   $��685,350,0,0q�6p   $��54��6�   ���	#FFFF1143$��Segoe Print)�6�   $��24(�6�   $
��Bold"�6�   6�   �� 5   
   -   5         ��Name$ AceOfSpades��5      $
��Left=�6%   $	��243��6@   $	��Top=�6M   $	��257��6e   $��
117,59,0,0q�6q   $��Images/AceOfSpades.png��6�    J� RenderTransformOrigin$ 0.576,0.445&�6�    5      �� 5      $' !Images/cards-removebg-preview.png��6   	 j� Stretch$	 Uniform=�6M   z�5      V� 5      .~�5      �� �� 5      
 �� AngleX$
 -0.427Q�6$   �� 5       �� Angle$ -0.656Q�6&   T� 5       T� X$ 1.022Q�6)    T� Y$ -0.127Q�63   5      5!      �� 5"   
   -   5        $ AceOfSpades_Copy��5"      $
��Left=�6*   $	��243��6E   $	��Top=�6R   $	��257��6j   $��
709,63,0,0q�6v   $��Images/AceOfSpades.png��6�   $ 0.576,0.445&�6�    5#      �� 5$      $' !Images/cards-removebg-preview.png��6   $	 Uniform=�6M   z�5&      V� 5'      .~�5(      �� �� 5)      $
 -0.427Q�6$   �� 5*      $ -0.656Q�6&   T� 5+      $ 1.022Q�6)   $ -0.127Q�63   5,      5.      5/      50      