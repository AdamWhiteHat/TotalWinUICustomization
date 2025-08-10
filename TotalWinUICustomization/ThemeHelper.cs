using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonClassesLibrary;

namespace TotalWinUICustomization
{
    public class ThemeHelper
    {

        /*
[Control Panel\Colors]
ActiveTitle=54 88 121
Background=255 250 239
ButtonFace=255 250 239
ButtonText=32 32 32
GrayText=103 103 103
Hilight=144 57 9
HilightText=255 245 227
HotTrackingColor=28 94 117
InactiveTitle=166 166 166
InactiveTitleText=0 0 0
TitleText=255 255 255
Window=255 250 239
WindowText=61 61 61
Scrollbar=255 255 255
Menu=255 255 255
WindowFrame=0 0 0
MenuText=0 0 0
ActiveBorder=128 128 128
InactiveBorder=192 192 192
AppWorkspace=128 128 128
ButtonShadow=128 128 128
ButtonHilight=192 192 192
ButtonDkShadow=0 0 0
ButtonLight=192 192 192
InfoText=0 0 0
InfoWindow=255 255 255
ButtonAlternateFace=192 192 192
GradientActiveTitle=0 0 0
GradientInactiveTitle=255 255 255
MenuHilight=0 0 0
MenuBar=255 255 255        
         */




        public static string GetThemeFile(WindowsUIMockupControl control)
        {
            string colorSection =
                @$"

[Control Panel\Colors]
ActiveTitle={ColorHelper.ColorToString(control.ActiveTitleColor)}
TitleText={ColorHelper.ColorToString(control.ActiveTitleTextColor)}
InactiveTitle={ColorHelper.ColorToString(control.InactiveTitleColor)}
InactiveTitleText={ColorHelper.ColorToString(control.InactiveTitleTextColor)}
GradientActiveTitle{ColorHelper.ColorToString(control.ActiveTitleGradientColor)}
GradientInactiveTitle{ColorHelper.ColorToString(control.InactiveTitleGradientColor)}
ButtonFace={ColorHelper.ColorToString(control.ButtonFaceColor)}
ButtonText={ColorHelper.ColorToString(control.ButtonTextColor)}
Window={ColorHelper.ColorToString(control.WindowColor)}
WindowText{ColorHelper.ColorToString(control.WindowTextColor)}
Background={ColorHelper.ColorToString(control.DesktopBackgroundColor)}
Menu{ColorHelper.ColorToString(control.MenuBarColor)}
MenuText{ColorHelper.ColorToString(control.MenuTextColor)}
MenuHilight{ColorHelper.ColorToString(control.MenuHighlightColor)}
Hilight={ColorHelper.ColorToString(control.HilightColor)}
HilightText={ColorHelper.ColorToString(control.HilightTextColor)}
InfoText{ColorHelper.ColorToString(control.InfoTextColor)}
InfoWindow{ColorHelper.ColorToString(control.InfoWindowColor)}
GrayText={ColorHelper.ColorToString(control.GrayTextColor)}
HotTrackingColor={ColorHelper.ColorToString(control.HotTrackingColor)}
Scrollbar={ColorHelper.ColorToString(control.ScrollbarColor)}
ActiveBorder={ColorHelper.ColorToString(control.ActiveBorderColor)}
InactiveBorder={ColorHelper.ColorToString(control.InactiveBorderColor)}
WindowFrame={ColorHelper.ColorToString(control.WindowFrameColor)}
";

            /*
            @$"
            AppWorkspace{ColorHelper.ColorToString(control)}
            MenuBar{ColorHelper.ColorToString(control)}

            ButtonShadow{ColorHelper.ColorToString(control)}
            ButtonDkShadow{ColorHelper.ColorToString(control)}
            ButtonHilight{ColorHelper.ColorToString(control)}
            ButtonLight{ColorHelper.ColorToString(control)}
            ButtonAlternateFace{ColorHelper.ColorToString(control)}
            ";
            */

            return Template + colorSection;
        }



        private static string Template =
             $@"; Copyright © Microsoft Corp.

[Theme]
; High Contrast White - IDS_THEME_DISPLAYNAME_HCWHITE
DisplayName=@%SystemRoot%\System32\themeui.dll,-2104
SetLogonBackground=0

; Computer - SHIDI_SERVER
[CLSID\{{20D04FE0-3AEA-1069-A2D8-08002B30309D}}\DefaultIcon]
DefaultValue=%SystemRoot%\System32\imageres.dll,-109

; UsersFiles - SHIDI_USERFILES
[CLSID\{{59031A47-3F72-44A7-89C5-5595FE6B30EE}}\DefaultIcon]
DefaultValue=%SystemRoot%\System32\imageres.dll,-123

; Network - SHIDI_MYNETWORK
[CLSID\{{F02C1A0D-BE21-4350-88B0-7367FC96EF3C}}\DefaultIcon]
DefaultValue=%SystemRoot%\System32\imageres.dll,-25

; Recycle Bin - SHIDI_RECYCLERFULL SHIDI_RECYCLER
[CLSID\{{645FF040-5081-101B-9F08-00AA002F954E}}\DefaultIcon]
Full=%SystemRoot%\System32\imageres.dll,-54
Empty=%SystemRoot%\System32\imageres.dll,-55

[Control Panel\Cursors]
Arrow=%SystemRoot%\cursors\aero_arrow.cur
Help=%SystemRoot%\cursors\aero_helpsel.cur
AppStarting=%SystemRoot%\cursors\aero_working.ani
Wait=%SystemRoot%\cursors\aero_busy.ani
NWPen=%SystemRoot%\cursors\aero_pen.cur
No=%SystemRoot%\cursors\aero_unavail.cur
SizeNS=%SystemRoot%\cursors\aero_ns.cur
SizeWE=%SystemRoot%\cursors\aero_ew.cur
Crosshair=
IBeam=
SizeNWSE=%SystemRoot%\cursors\aero_nwse.cur
SizeNESW=%SystemRoot%\cursors\aero_nesw.cur
SizeAll=%SystemRoot%\cursors\aero_move.cur
UpArrow=%SystemRoot%\cursors\aero_up.cur
DefaultValue=Windows Default
DefaultValue.MUI=@main.cpl,-1020
Hand=%SystemRoot%\cursors\aero_link.cur
Link=

[Control Panel\Desktop]
Wallpaper=
TileWallpaper=0
WallpaperStyle=10
Pattern=

[VisualStyles]
Path=%SystemRoot%\resources\themes\Aero\AeroLite.msstyles
ColorStyle=NormalColor
Size=NormalSize
HighContrast=4

[boot]
SCRNSAVE.EXE=

[MasterThemeSelector]
MTSM=RJSPBS

[Sounds]
; IDS_SCHEME_DEFAULT
SchemeName=@%SystemRoot%\System32\mmres.dll,-800

";

    }
}
