using System;
using System.Collections;
using System.Text;
using System.Data;

namespace FlexAccess_Server.Permissions
{
  class Permission
  {

    public static void checkPermission(Node node, Person person)
    {
      Entry entry = null;

      int intReturn;

      // Opzoeken welke entry's er door deze node kunnen worden geopend
      FlexAccessServerDataSetTableAdapters.entryTableAdapter entryAdapter = new FlexAccess_Server.FlexAccessServerDataSetTableAdapters.entryTableAdapter();
      FlexAccessServerDataSet.entryDataTable entryData = entryAdapter.getEntryByNodeID(node.NodeID);

      Hashtable entryHashTable = Controller.getEntryList();

      foreach (FlexAccessServerDataSet.entryRow entryRow in entryData)
      {
        int entryHashKey = entryRow.ent_id.GetHashCode();
        if (entryHashTable.Contains(entryHashKey))
        {
          entry = (Entry)entryHashTable[entryHashKey];

          // Welke entry's mag de persoon openen met deze node
          intReturn = personEntryPermission(node, person, entry);
          if (intReturn > -1)
          {
            if (Convert.ToBoolean(intReturn))
            {
              Console.WriteLine(person.Fullname + ", heeft toegang tot entry: \t\t\t\t\t\t\t\t" + entry.EntryName);
            }
            else
            {
              Console.WriteLine(person.Fullname + ", heeft geen toegang tot entry: \t\t\t\t\t\t\t" + entry.EntryName);
            }
          }
          else
          {
            Console.WriteLine(person.Fullname + ", geen toegang gedefineerd tot entry: \t\t\t\t\t" + entry.EntryName);

            // Niet bekend (Niet gedefineerd in de database, waarde -1)
            // Controle persoon toegang bij de zone
            intReturn = personZonePermission(node, person, entry);
            if (intReturn > -1)
            {
              if (Convert.ToBoolean(intReturn))
              {
                Console.WriteLine(person.Fullname + ", heeft toegang tot zone: \t\t\t\t\t\t\t" + entry.zone.ZoneName);
              }
              else
              {
                Console.WriteLine(person.Fullname + ", heeft geen toegang tot zone: \t\t\t\t\t\t\t" + entry.zone.ZoneName);
              }
            }
            else
            {
              Console.WriteLine(person.Fullname + ", geen toegang gedefineerd tot zone: \t\t\t\t\t\t" + entry.zone.ZoneName);
              // Niet bekend (Niet gedefineerd in de database, waarde -1)
              // Controle persoon groep toegang bij de entry
              intReturn = personGroupEntryPermission(node, person, entry);
              if (intReturn > -1)
              {
                if (Convert.ToBoolean(intReturn))
                {
                  Console.WriteLine(person.Fullname + ", zijn groep geeft hem toegang tot entry: \t" + entry.EntryName);
                }
                else
                {
                  Console.WriteLine(person.Fullname + ", zijn groep geeft hem toegang tot entry: \t" + entry.EntryName);
                }
              }
              else
              {
                Console.WriteLine(person.Fullname + ", zijn groep heeft geen toegang gedefineerd tot entry: \t" + entry.EntryName);
                // Niet bekend (Niet gedefineerd in de database, waarde -1)
                // Controle persoon groep toegang bij de zone
                intReturn = personGroupZonePermission(node, person, entry);
                if (intReturn > -1)
                {
                  if (Convert.ToBoolean(intReturn))
                  {
                    Console.WriteLine(person.Fullname + ", zijn groep geeft hem toegang tot zone: \t" + entry.zone.ZoneName);
                  }
                  else
                  {
                    Console.WriteLine(person.Fullname + ", zijn groep geeft hem geen toegang tot zone: \t" + entry.zone.ZoneName);
                  }
                }
                else
                {
                  Console.WriteLine(person.Fullname + ", zijn groep heeft geen toegang gedefineerd tot zone: \t" + entry.zone.ZoneName);
                }
              }
            }
          }
        }
      }
    }

    private static int personEntryPermission(Node node, Person person, Entry entry)
    {
      FlexAccessServerDataSetTableAdapters.person_has_entryTableAdapter personHasEntryAdapter = new FlexAccess_Server.FlexAccessServerDataSetTableAdapters.person_has_entryTableAdapter();
 
      // Geen opgegeven waarde
      if (personHasEntryAdapter.personHasEntryAccess(person.PersonID, entry.EntryID) == null)
      {
        return -1;
      }
      // Bekend dat de persoon geen of wel toegang heeft bij de entry
      else
      {
        if (Convert.ToBoolean(personHasEntryAdapter.personHasEntryAccess(person.PersonID, entry.EntryID)))
        {
          entry.powerOn(node, person, true, "Persoon (" + person.Fullname + ") heeft entry (" + entry.EntryName + ") toegang");
          return 1;
        }
        else
        {
          return 0;
        }
      }
    }

    private static int personZonePermission(Node node, Person person, Entry entry)
    {
      FlexAccessServerDataSetTableAdapters.person_has_zoneTableAdapter personHasZoneAdapter = new FlexAccess_Server.FlexAccessServerDataSetTableAdapters.person_has_zoneTableAdapter();
      
      // Geen opgegeven waarde
      if (personHasZoneAdapter.personHasZoneAccess(person.PersonID, entry.zone.ZoneID) == null)
      {
        return -1;
      }
      // Bekend dat de persoon geen of wel toegang heeft bij de zone van de entry
      else
      {
        if (Convert.ToBoolean(personHasZoneAdapter.personHasZoneAccess(person.PersonID, entry.zone.ZoneID)))
        {
          entry.powerOn(node, person, true, "Persoon (" + person.Fullname + ") heeft zone (" + entry.zone.ZoneName + ") toegang");
          return 1;
        }
        else 
        {
          return 0;
        }
      }
    }

    private static int personGroupEntryPermission(Node node, Person person, Entry entry)
    {
      int returnValue = -1;

      // Van welke groep(en) is de persoon lid
      Hashtable personGroupHashtable = person.personGroup();

      // Groep lijst doorlopen
      foreach (PersonGroup personGroup in personGroupHashtable.Values)
      {
        FlexAccessServerDataSetTableAdapters.persongroup_has_entryTableAdapter personGroupHasEntryAdapter = new FlexAccess_Server.FlexAccessServerDataSetTableAdapters.persongroup_has_entryTableAdapter();
        if (personGroupHasEntryAdapter.personGroupHasEntryAccess(personGroup.PersonGroupID, entry.EntryID) != null)
        {
          if (Convert.ToBoolean(personGroupHasEntryAdapter.personGroupHasEntryAccess(personGroup.PersonGroupID, entry.EntryID)))
          {
            if (returnValue == -1)
            {
              returnValue = 1;
            }
          }
          else
          {
            returnValue = 0;
          }
        }
      }
      if (returnValue == 1)
      {
        entry.powerOn(node, person, true, "Persoongroep (*) heeft entry (" + entry.EntryName + ") toegang");
      }

      return returnValue;
    }

    private static int personGroupZonePermission(Node node, Person person, Entry entry)
    {
      int returnValue = -1;

      // Van welke groep(en) is de persoon lid
      Hashtable personGroupHashTable = person.personGroup();

      // Groep lijst doorlopen, controle of alle persoon groepen wel zone toegang hebben
      foreach (PersonGroup personGroup in personGroupHashTable.Values)
      {
        FlexAccessServerDataSetTableAdapters.persongroup_has_zoneTableAdapter personGroupHasZoneAdapter = new FlexAccess_Server.FlexAccessServerDataSetTableAdapters.persongroup_has_zoneTableAdapter();
        if (personGroupHasZoneAdapter.personGroupHasZoneAccess(personGroup.PersonGroupID, entry.zone.ZoneID) != null)
        {
          if (Convert.ToBoolean(personGroupHasZoneAdapter.personGroupHasZoneAccess(personGroup.PersonGroupID, entry.zone.ZoneID)))
          {
            if (returnValue == -1)
            {
              returnValue = 1;
            }
          }
          else
          {
            returnValue = 0;
          }
        }
      }

      if (returnValue == 1)
      {
        entry.powerOn(node, person, true, "Persoongroep (*) heeft zone (" + entry.zone.ZoneName + ") toegang");
      }
      return returnValue;
    }
  }
}
