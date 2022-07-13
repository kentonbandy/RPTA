using RPTA.Exceptions;
using ServiceStack.DataAnnotations;
using System.ComponentModel.DataAnnotations;

namespace RPTA.Models
{
    /// <summary>
    /// Sets a single condition to check against.
    /// 4 possible conditions (detected based on what is and is not null):
    /// Item in Container | Item in Player Inventory | Item in Location | Container full
    /// Incorrect setup will throw exception when Satisfied is accessed.
    /// </summary>
    public class Condition
    {
        [Key]
        public int ConditionId { get; set; }
        public Item? Item { get; set; }
        public Container? Container { get; set; }
        public Player? Player { get; set; }
        public Location? Location { get; set; }
        [Computed]
        public bool Satisfied
        {
            get
            {
                if (Item != null)
                {
                    // Container must contain Item
                    if (Container != null)
                    {
                        return Container.Slots.Any(c => c.Item == Item);
                    }
                    // Player Inventory must contain Item
                    else if (Player != null)
                    {
                        return Player.Inventory.Any(i => i.Item == Item);
                    }
                    // Location must contain Item
                    else if (Location != null)
                    {
                        return Location.Items.Contains(Item);
                    }
                }
                // Container must be full
                else if (Container != null)
                {
                    return Container.Full;
                }
                // Condition is invalid
                throw new InvalidConditionException();
            }
        }
    }
}
