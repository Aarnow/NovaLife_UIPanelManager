using Life;
using Life.Network;
using Life.UI;
using System;
using System.Collections.Generic;

namespace UIPanelManager
{
    public abstract class PanelManager : Plugin
    {
        public static readonly Dictionary<NotificationManager.Type, string> Colors = new Dictionary<NotificationManager.Type, string>
        {
            { NotificationManager.Type.Error, "#DD304E" },
            { NotificationManager.Type.Info, "#4287F5" },
            { NotificationManager.Type.Success, "#85DF6A" },
            { NotificationManager.Type.Warning, "#FCDD36" }
        };
        public PanelManager(IGameAPI api) : base(api)
        {
        }

        public override void OnPluginInit()
        {
            base.OnPluginInit();

            Console.WriteLine($"Plugin \"UIPanelManager\" initialisé avec succès.");
        }  

        public static void Notification(Player player, string title, string message, NotificationManager.Type notificationType, int delay = 6)
        {
            try
            {
                player.Notify($"<color={Colors[notificationType]}>{title}</color>", $"{message}", notificationType, delay);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"ERROR - Notification: {ex}");
            }
        }

        public static void NextPanel(Player player, UIPanel currentPanel, Action nextPanel)
        {
            player.ClosePanel(currentPanel);
            nextPanel.Invoke();
        }

        public static void Quit(UIPanel panel, Player player)
        {
            try
            {
                player.ClosePanel(panel);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"ERROR - Quit :{ex}");
            }
        }
    }
}