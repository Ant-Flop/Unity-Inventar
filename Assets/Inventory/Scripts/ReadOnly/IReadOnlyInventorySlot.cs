using System;

namespace Inventory
{
    public interface IReadOnlyInventorySlot
    {
        event Action<string> ItemIdChanged;
        event Action<int> ItemAmountChanged;

        string ItemId { get; }
        int Amount { get; }
        bool isEmpty { get; }
    }
}