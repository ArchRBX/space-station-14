using Robust.Shared.GameStates;
using Robust.Shared.Serialization;

namespace Content.Shared.Pinpointer;

/// <summary>
/// This is used for a <see cref="NavMapBeaconComponent"/> that can be configured with a UI.
/// </summary>
[RegisterComponent, NetworkedComponent]
[Access(typeof(SharedNavMapSystem))]
public sealed partial class ConfigurableNavMapBeaconComponent : Component
{

}

[Serializable, NetSerializable]
public sealed class NavMapBeaconConfigureBuiMessage : BoundUserInterfaceMessage
{
    public string? Text;
    public bool Enabled;
    public Color Color;
    public bool Broadcast;

    public NavMapBeaconConfigureBuiMessage(string? text, bool enabled, Color color, bool broadcast)
    {
        Text = text;
        Enabled = enabled;
        Color = color;
        Broadcast = broadcast;
    }
}

[Serializable, NetSerializable]
public enum NavMapBeaconUiKey : byte
{
    Key
}

[Serializable, NetSerializable]
public enum NavMapBeaconVisuals : byte
{
    Enabled
}
