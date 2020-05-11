# Prism.Avalonia.Samples
Some examples of the [Prism.Avalonia](https://github.com/AvaloniaCommunity/Prism.Avalonia) framework.

Examples are based on these [WPF Examples](https://github.com/PrismLibrary/Prism-Samples-Wpf) from the [Prism Library](https://github.com/PrismLibrary) and demonstrate how to use Prism.Avalonia.

Examples that do not work, because of some different behavoir in avalonia:

Solution | Project | Note
--- | --- | ---
[Command.sln](https://github.com/EinApfelBaum/Prism.Avalonia.Samples/tree/master/src/11-Commands) | UsingCompositeCommands <br> IActiveAwareCommands (missing) | No regions during module initialization
[Navigation.sln](https://github.com/EinApfelBaum/Prism.Avalonia.Samples/tree/master/src/17-Navigation) | NavigationParticipation <br> NavigationToExistintgViews <br> PassingParameters | TabControl with regions not working

I updated some of these examples, so they can be built.