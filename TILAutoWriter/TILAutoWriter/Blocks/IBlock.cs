using System;

namespace TILAutoPublisher
{
    public interface IBlock
    {
        string GetHtml();
        event EventHandler OnRemove;
        event EventHandler OnMoveUp;
        event EventHandler OnMoveDown;
    }
}