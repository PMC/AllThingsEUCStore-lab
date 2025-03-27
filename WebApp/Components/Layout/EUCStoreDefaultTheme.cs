using MudBlazor;

namespace WebApp.Components.Layout;

public class EUCStoreDefaultTheme
{
    public static MudTheme Theme()
    {
        return new()
        {
            PaletteLight = new PaletteLight()
            {
                AppbarBackground = "rgb(17, 24, 39)",
                AppbarText = "rgb(255, 255, 255)",
                Background = "#eeeeee",
                DrawerIcon = "#d1d5db",
                DrawerText = "#d1d5db",
                DrawerBackground = "#1f2937",
                Primary = "#4969ee",
                Error = "#ff0000",
                Secondary = "#334155",
                Tertiary = "#f6fdca",
                LinesInputs = "#dedede",
                GrayLight = "#e8e8e8",
                GrayLighter = "#f9f9f9",
                Black = "#110e2d",

            },
            PaletteDark = new PaletteDark()
            {
                Primary = "#7e6fff",
                Surface = "#1e1e2d",
                Background = "#1a1a27",
                BackgroundGray = "#151521",
                AppbarText = "#92929f",
                AppbarBackground = "rgba(26,26,39,0.8)",
                DrawerBackground = "#1a1a27",
                ActionDefault = "#74718e",
                ActionDisabled = "#9999994d",
                ActionDisabledBackground = "#605f6d4d",
                TextPrimary = "#b2b0bf",
                TextSecondary = "#92929f",
                TextDisabled = "#ffffff33",
                DrawerIcon = "#92929f",
                DrawerText = "#92929f",
                GrayLight = "#2a2833",
                GrayLighter = "#1e1e2d",
                Info = "#4a86ff",
                Success = "#3dcb6c",
                Warning = "#ffb545",
                Error = "#ff3f5f",
                LinesDefault = "#33323e",
                TableLines = "#33323e",
                Divider = "#292838",
                OverlayLight = "#1e1e2d80",

            },
            LayoutProperties = new LayoutProperties()
            {
                DefaultBorderRadius = "8px"
            },
            Typography = new Typography()
            {

                Default = new DefaultTypography()
                {
                    FontFamily = new[] { "InterPMC", "sans-serif"
                },
                    FontSize = "15px"
                },
                H1 = new H1Typography() { FontWeight = "700" },
                H2 = new H2Typography() { FontWeight = "700" },
                H3 = new H3Typography() { FontWeight = "700" },
                H4 = new H4Typography() { FontWeight = "700" },
                H5 = new H5Typography() { FontWeight = "700" },
                H6 = new H6Typography() { FontWeight = "700" },
                Button = new ButtonTypography() { FontWeight = "700" }

            }
        };
    }
}