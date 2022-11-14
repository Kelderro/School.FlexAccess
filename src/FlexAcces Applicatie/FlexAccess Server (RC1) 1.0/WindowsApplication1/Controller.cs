using System;
using System.Collections;
using System.Threading;

namespace FlexAccess_Server
{
  class Controller
  {
    // ServerLockDown
    public static Boolean serverLockDown = false;

    // Server object aanmaken
    public static Network.Server server;

    // Entry controllers ophalen
    public static Hashtable entryControllerHashTable = getEntryControlList();

    // Entry zones ophalen
    public static Hashtable entryZoneHashTable = getZoneList();

    // Entry hashtable aanmaken voor opslag
    public static Hashtable entryHashTable = new Hashtable();

    public static void Main()
    {
      // Server opstarten
      server = new Network.Server();
	  }

    public static Hashtable getEntryList()
    {
      // Entry controllers ophalen
      Hashtable entryControllerHashTable = getEntryControlList();

      // Entry zones ophalen
      Hashtable entryZoneHashTable = getZoneList();

      // Entry's ophalen
      FlexAccessServerDataSetTableAdapters.entryTableAdapter entryAdapter = new FlexAccess_Server.FlexAccessServerDataSetTableAdapters.entryTableAdapter();
      FlexAccessServerDataSet.entryDataTable entryData = entryAdapter.GetData();

      foreach (FlexAccessServerDataSet.entryRow entryRow in entryData)
      {
        // Bestaat de entry
        int entryKey = entryRow.ent_id.GetHashCode();
        if (entryHashTable.Contains(entryKey))
        {
          // Entry bestaat.
          Entry entry = (Entry)entryHashTable[entryKey];

          if (entryRow.ent_active)
          {
            // Entry is nog actief in de database. Update entry.
            entry.EntryName = entryRow.ent_name;
            entry.PortNumber = entryRow.ecn_port_number;
          }
          else
          {
            // Entry niet actief in de database. Verwijder entry.
            entry.powerOn(null, null, false, "Entry is uitgeschakeld in database. Entry wordt verwijderd uit de server hashtable.");
            entryHashTable.Remove(entryKey);
          }
        }
        else
        {
          // Nieuwe entry gevonden
          if (entryRow.ent_active)
          {
            // Entry is actief. Toevoegen aan hashset.
            int entryControllerKey = entryRow.ecn_id.GetHashCode();
            if (entryControllerHashTable.Contains(entryControllerKey))
            {
              // EntryController bestaat in zoneHashTable
              EntryController entryController = (EntryController)entryControllerHashTable[entryControllerKey];

              int zoneKey = entryRow.zne_id.GetHashCode();
              if (entryZoneHashTable.Contains(zoneKey))
              {
                // Zone bestaat in zoneHashTable
                Zone zone = (Zone)entryZoneHashTable[zoneKey];

                Entry entry = new Entry(entryRow.ent_id, entryRow.ent_name, entryRow.ecn_port_number, zone, entryController);
                entryHashTable.Add(entryKey, entry);
              }
            }
          }
        }
      }
      return entryHashTable;
    }

    private static Hashtable getEntryControlList()
    {
      // Entry controllers hashtable aanmaken voor opslag
      Hashtable entryControllerHashTable = new Hashtable();

      // Entry controllers ophalen
      FlexAccessServerDataSetTableAdapters.entry_controllerTableAdapter entryControllerAdapter = new FlexAccess_Server.FlexAccessServerDataSetTableAdapters.entry_controllerTableAdapter();
      FlexAccessServerDataSet.entry_controllerDataTable entryControllerData = entryControllerAdapter.GetData();

      foreach (FlexAccessServerDataSet.entry_controllerRow entryControllerRow in entryControllerData)
      {
        EntryController entryController = new EntryController(entryControllerRow.ecn_id, entryControllerRow.ecn_ip, entryControllerRow.ecn_active);

        int key = entryControllerRow.ecn_id.GetHashCode();
        entryControllerHashTable.Add(key, entryController);
      }
      return entryControllerHashTable;
    }

    public static Hashtable getZoneList()
    {
      // Zone hashtable aanmaken voor opslag
      Hashtable zoneHashTable = new Hashtable();

      // Zone's ophalen
      FlexAccessServerDataSetTableAdapters.zoneTableAdapter zoneAdapter = new FlexAccess_Server.FlexAccessServerDataSetTableAdapters.zoneTableAdapter();
      FlexAccessServerDataSet.zoneDataTable zoneData = zoneAdapter.GetData();

      foreach (FlexAccessServerDataSet.zoneRow zoneRow in zoneData)
      {
        Zone zone = new Zone(zoneRow.zne_id, zoneRow.zne_name);

        int key = zoneRow.zne_id.GetHashCode();
        zoneHashTable.Add(key, zone);
      }
      return zoneHashTable;
    }
  }
}