using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace pattern_iterator_netcore
{
    public class Browser
    {
        private List<BrowserHistory> _histories;
        public Browser()
        {
            _histories = new List<BrowserHistory>();
        }
        public void PushHistory(BrowserHistory history)
        {
            _histories.Add(history);
        }
        public BrowserHistory PopHistory()
        {
            var lastElement = _histories[^1];
            _histories.Remove(lastElement);
            return lastElement;
        }
    }
}