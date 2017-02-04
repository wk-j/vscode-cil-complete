#addin "nuget:?package=Cake.SquareLogo"

Task("Publish").Does(() => {
    StartProcess("vsce", new ProcessSettings {
        Arguments = "publish"
    });
});

Task("Icon").Does(() =>{
    CreateLogo("IL", "images/icon.png", new LogoSettings {
        Background = "Indigo",
        FontFamily = "Phosphate",
        Foreground = "White",
        Padding = 50
    });
});

var target = Argument("target", "default");
RunTarget(target);