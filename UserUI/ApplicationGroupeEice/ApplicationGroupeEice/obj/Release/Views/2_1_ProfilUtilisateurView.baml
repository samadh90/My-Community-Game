   M S B A M L   `   `   `  ���� P  LApplicationGroupeEice, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:ApplicationGroupeEice.ViewsApplicationGroupeEice.Views  7    1ApplicationGroupeEice.Views.ProfilUtilisateurView   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     ;local)clr-namespace:ApplicationGroupeEice.Views     $	��580��$
��1201��.���   � RowDefinitions  �� $��* ��� $��* ��� $��* ��� $��* ��� $��* ��� $��* � � ColumnDefinitions �� $��20 ��� $��* ��� $��* ��� $��* ��� $��* ��� $��* ��� $��20 �.+��� $��0��$��1��$��6��$��2��$��Stretch=�$��Center=�.+���  �� Orientation$ 
Horizontal=�.+��� $��60 0 0 0q�$��30������  �� Path$' !UserData.UserStatus.StatusIconUrl��� $��50��$��40 0 0 0q����� $# UserData.UserRank.RankIconUrl��� -    ��Name$ UserrData_UserPublicName��
�������$��40(�$��cambria)�$��20 0 0 0q�$��Center=����� $ UserData.UserPublicName��� $	��400��$	��380��$��20q�$7��1/ApplicationGroupeEice;component/Image/crysis.png�� J� Clip @�  @� Center$ 170,170&� @� RadiusX$	 150Q� @� RadiusY$	 170Q��� $ 
Horizontal=�$��1��$��3��$��3��$��Center=�.+��� $6��0/ApplicationGroupeEice;component/Image/Score.png��$
��Fill=��� $��Score :��
�������$��40(�$��Cambria)�$��Center=�$��10q�$��Center=��� 
�������$��40(�$��cambria)�$��Center=�$��10q�$��Center=����� $ UserData.UserScore��� $��3��$��3��$��3��$��Stretch=�$��Center=�.+��� $��	Trophées��
�������$��20(�$��Cambria)�$��Center=�$��10q��� -   $��NombreTrophée��
�������$��20(�$��cambria)�$��Center=�$��10q����� $ UserData.NumberOfTrophies��� $	��100��$	��100��$��10q�$U��O/ApplicationGroupeEice;component/Image/iconfinder_advantage_quality_1034364.png��$
��Fill=��� $��3��$��4��$��3��$��Stretch=�$��Center=�.+��� $
��Rang��
�������$��20(�$��Cambria)�$��Center=�$��10q��� -   $��
RangJoueur��
�������$��20(�$��cambria)�$��Center=�$��10q����� $  UserData.UserRank.RankName��� $	��100��$	��100��$��10q�$5��//ApplicationGroupeEice;component/Image/Rank.png��$
��Fill=��� $��3��$��5��$��3��$��Stretch=�$��Center=�.+��� $��Défis réussis��
�������$��20(�$��Cambria)�$��Center=�$��10q��� -   $ NombreDéfisRéussis��$��0��
�������$��20(�$��cambria)�$��Center=�$��10q��� $	��100��$	��100��$��10q�$;��5/ApplicationGroupeEice;component/Image/LogoDéfis.png��$
��Fill=�