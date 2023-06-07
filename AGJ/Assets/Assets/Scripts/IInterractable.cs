public interface IInteractable
{
    float MaxRange { get; }
    void OnStartHover();
    void OnItemInteract();
    void OnEndHover();
}