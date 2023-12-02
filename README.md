# Novalife Plugin PanelHelper v1.0.0

Ce plugin Novalife UIPanelMangager fournit des fonctionnalit�s facilitant la cr�ation d'interface lors du d�veloppement
Il s'agit d'une d�pendance pour les plugins employant UIPanelManager.

## Table des Mati�res

- [Installation](#installation)
- [Utilisation](#utilisation)
- [Fonctionnalit�s](#fonctionnalit�s)
- [Droits de Propri�t� Intellectuelle](#droits-de-propri�t�-intellectuelle)

## Installation

1. T�l�chargez le fichier `PanelHelper.dll` depuis la page des releases de ce d�p�t.
2. Ajoutez le fichier `PanelHelper.dll` dans le dossier des plugins de votre serveur Novalife.

## Utilisation

Le Plugin UIPanelManager �tend les fonctionnalit�s de Novalife pour faciliter l'ajout d'interfaces en jeu.
Pour l'utiliser, suivez ces �tapes :

1. Int�grez le Plugin UIPanelManager.dll en tant que r�f�rence dans votre projet Novalife.
2. Vous n'avez plus qu'� utiliser les fonctionnalit�s fournies par UIPanelManager.

## Fonctionnalit�s

Voici un exemple minimal de cr�ation de panneau en utilisant UIPanelManager :

```csharp
// Changer de panel
PanelManager.NextPanel(player, ui, () => VotrePanel());

// Notifier un joueur
PanelManager.Notification(player, "Titre", "Votre message", NotificationManager.Type.Error);
PanelManager.Notification(player, "Titre", "Votre message", NotificationManager.Type.Warning);
PanelManager.Notification(player, "Titre", "Votre message", NotificationManager.Type.Info);
PanelManager.Notification(player, "Titre", "Votre message", NotificationManager.Type.Success);

// Fermer un Panel
panel.AddButton("Fermer", (ui) => PanelManager.Quit(ui, player));
```

## Droits de Propri�t� Intellectuelle

Je vous demande simplement de respecter le temps que j'ai mis dans ce plugin.
Merci de ne pas vous approprier le plugin, de ne pas le copier b�tement, et de ne pas faire des trucs �tranges avec.

Pour discuter, contactez-moi sur discord: Aarnow
Serveur discord: https://discord.gg/8j2suEE9Mf