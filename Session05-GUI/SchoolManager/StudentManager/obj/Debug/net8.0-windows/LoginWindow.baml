   M S B A M L   `   `   `  ����I  EStudentManager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:StudentManagerStudentManager  5   	        StudentManager.LoginWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:StudentManager     5   	     � Title$  Login to the system...��5   	   $	��450��6(   $	��800��65   ���#FA8072 � WindowStartupLocation$ CenterScreen=�5	   	   .��5
      �  � RowDefinitions 5   
   �� 5      $
��251* �6   �� 5      $
��183* �6   .+�5   
   ��  �� RadiusX$ 20��6    �� RadiusY$ 29��6!   ���#DE3163$
��Left=�6=   $	��323��6X   
���   �$	��Top=�6t   $	��472��6�   $��2��6�   $��
152,86,0,0q�6�   �� 5   
      HeaderLabel#��[  5      $��Login��5      $
��Left=�5      $��69��5      $��
312,12,0,0q�5      $	��Top=�5      $	��152��5       J� RenderTransformOrigin$ 0.5,0.5&�5      �� 5   
   -   5         ��Name$ LoginButton��5      ���#DFFF00$��	ExtraBold"�5       $��20(�5!      ���#CCCCFF$��Log in��5#      $
��Left=�5$      $��53��5%      $��
177,58,0,0q�6   $	��Top=�5&      $	��154��5'      $��1��5(   '   �� 5)   
   -   5        $ 
QuitButton��5*      ���#DFFF00$��	ExtraBold"�5,      $��20(�5-      ���#CCCCFF$
��Quit��5/      $
��Left=�50      $��53��51      $��
450,58,0,0q�6   $	��Top=�52      $	��154��53      $��1��62   �� 54   
   $��Username��6   $
��Left=�6#   $��177,121,0,0q�6>   $	��Top=�6S   �� 55   
   $��Password��6   $
��Left=�6#   $��177,207,0,0q�6>   $	��Top=�6S   �� 56   
   -   5         ��Name$ UsernameTextBox��56      $
��Left=�57      $��296,129,0,0q�58       �� TextWrapping$
 Wrap=�6'   $	��Top=�59      $	��282��6*   �� 5:   
   -   5        $ PasswordTextBox��5:      $
��Left=�6+   $��296,215,0,0q�5;      $
 Wrap=�6'   $	��Top=�5<      $	��282��6*   5>      5?      