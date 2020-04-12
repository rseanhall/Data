// Copyright (c) .NET Foundation and contributors. All rights reserved. Licensed under the Microsoft Reciprocal License. See LICENSE.TXT file in the project root for full license information.

namespace WixToolset.Data.WindowsInstaller
{
    public static class WindowsInstallerTableDefinitions
    {
        public static readonly TableDefinition ActionText = new TableDefinition(
            "ActionText",
            new[]
            {
                new ColumnDefinition("Action", ColumnType.String, 72, primaryKey: true, nullable: false, ColumnCategory.Identifier, description: "Name of action to be described.", modularizeType: ColumnModularizeType.Column),
                new ColumnDefinition("Description", ColumnType.Localized, 0, primaryKey: false, nullable: true, ColumnCategory.Text, description: "Localized description displayed in progress dialog and log when action is executing."),
                new ColumnDefinition("Template", ColumnType.Localized, 0, primaryKey: false, nullable: true, ColumnCategory.Template, description: "Optional localized format template used to format action data records for display during action execution.", modularizeType: ColumnModularizeType.Property),
            },
            tupleDefinitionName: TupleDefinitions.ActionText.Name,
            tupleIdIsPrimaryKey: false
        );

        public static readonly TableDefinition AdminExecuteSequence = new TableDefinition(
            "AdminExecuteSequence",
            new[]
            {
                new ColumnDefinition("Action", ColumnType.String, 72, primaryKey: true, nullable: false, ColumnCategory.Identifier, description: "Name of action to invoke, either in the engine or the handler DLL."),
                new ColumnDefinition("Condition", ColumnType.String, 255, primaryKey: false, nullable: true, ColumnCategory.Condition, description: "Optional expression which skips the action if evaluates to expFalse.If the expression syntax is invalid, the engine will terminate, returning iesBadActionData.", forceLocalizable: true),
                new ColumnDefinition("Sequence", ColumnType.Number, 2, primaryKey: false, nullable: true, ColumnCategory.Unknown, minValue: -4, maxValue: 32767, description: "Number that determines the sort order in which the actions are to be executed.  Leave blank to suppress action."),
            },
            tupleIdIsPrimaryKey: true
        );

        public static readonly TableDefinition Condition = new TableDefinition(
            "Condition",
            new[]
            {
                new ColumnDefinition("Feature_", ColumnType.String, 38, primaryKey: true, nullable: false, ColumnCategory.Identifier, keyTable: "Feature", keyColumn: 1, description: "Reference to a Feature entry in Feature table."),
                new ColumnDefinition("Level", ColumnType.Number, 2, primaryKey: true, nullable: false, ColumnCategory.Unknown, minValue: 0, maxValue: 32767, description: "New selection Level to set in Feature table if Condition evaluates to TRUE."),
                new ColumnDefinition("Condition", ColumnType.String, 255, primaryKey: false, nullable: true, ColumnCategory.Condition, description: "Expression evaluated to determine if Level in the Feature table is to change.", forceLocalizable: true),
            },
            tupleDefinitionName: TupleDefinitions.Condition.Name,
            tupleIdIsPrimaryKey: false
        );

        public static readonly TableDefinition AdminUISequence = new TableDefinition(
            "AdminUISequence",
            new[]
            {
                new ColumnDefinition("Action", ColumnType.String, 72, primaryKey: true, nullable: false, ColumnCategory.Identifier, description: "Name of action to invoke, either in the engine or the handler DLL."),
                new ColumnDefinition("Condition", ColumnType.String, 255, primaryKey: false, nullable: true, ColumnCategory.Condition, description: "Optional expression which skips the action if evaluates to expFalse.If the expression syntax is invalid, the engine will terminate, returning iesBadActionData.", forceLocalizable: true),
                new ColumnDefinition("Sequence", ColumnType.Number, 2, primaryKey: false, nullable: true, ColumnCategory.Unknown, minValue: -4, maxValue: 32767, description: "Number that determines the sort order in which the actions are to be executed.  Leave blank to suppress action."),
            },
            tupleIdIsPrimaryKey: true
        );

        public static readonly TableDefinition AdvtExecuteSequence = new TableDefinition(
            "AdvtExecuteSequence",
            new[]
            {
                new ColumnDefinition("Action", ColumnType.String, 72, primaryKey: true, nullable: false, ColumnCategory.Identifier, description: "Name of action to invoke, either in the engine or the handler DLL."),
                new ColumnDefinition("Condition", ColumnType.String, 255, primaryKey: false, nullable: true, ColumnCategory.Condition, description: "Optional expression which skips the action if evaluates to expFalse.If the expression syntax is invalid, the engine will terminate, returning iesBadActionData.", forceLocalizable: true),
                new ColumnDefinition("Sequence", ColumnType.Number, 2, primaryKey: false, nullable: true, ColumnCategory.Unknown, minValue: -4, maxValue: 32767, description: "Number that determines the sort order in which the actions are to be executed.  Leave blank to suppress action."),
            },
            tupleIdIsPrimaryKey: true
        );

        public static readonly TableDefinition AdvtUISequence = new TableDefinition(
            "AdvtUISequence",
            new[]
            {
                new ColumnDefinition("Action", ColumnType.String, 72, primaryKey: true, nullable: false, ColumnCategory.Identifier, description: "Name of action to invoke, either in the engine or the handler DLL."),
                new ColumnDefinition("Condition", ColumnType.String, 255, primaryKey: false, nullable: true, ColumnCategory.Condition, description: "Optional expression which skips the action if evaluates to expFalse.If the expression syntax is invalid, the engine will terminate, returning iesBadActionData.", forceLocalizable: true),
                new ColumnDefinition("Sequence", ColumnType.Number, 2, primaryKey: false, nullable: true, ColumnCategory.Unknown, minValue: -4, maxValue: 32767, description: "Number that determines the sort order in which the actions are to be executed.  Leave blank to suppress action."),
            },
            tupleIdIsPrimaryKey: true
        );

        public static readonly TableDefinition AppId = new TableDefinition(
            "AppId",
            new[]
            {
                new ColumnDefinition("AppId", ColumnType.String, 38, primaryKey: true, nullable: false, ColumnCategory.Guid),
                new ColumnDefinition("RemoteServerName", ColumnType.String, 255, primaryKey: false, nullable: true, ColumnCategory.Formatted, modularizeType: ColumnModularizeType.Property),
                new ColumnDefinition("LocalService", ColumnType.String, 255, primaryKey: false, nullable: true, ColumnCategory.Text),
                new ColumnDefinition("ServiceParameters", ColumnType.String, 255, primaryKey: false, nullable: true, ColumnCategory.Text),
                new ColumnDefinition("DllSurrogate", ColumnType.String, 255, primaryKey: false, nullable: true, ColumnCategory.Text),
                new ColumnDefinition("ActivateAtStorage", ColumnType.Number, 2, primaryKey: false, nullable: true, ColumnCategory.Unknown, minValue: 0, maxValue: 1),
                new ColumnDefinition("RunAsInteractiveUser", ColumnType.Number, 2, primaryKey: false, nullable: true, ColumnCategory.Unknown, minValue: 0, maxValue: 1),
            },
            tupleDefinitionName: TupleDefinitions.AppId.Name,
            tupleIdIsPrimaryKey: false
        );

        public static readonly TableDefinition AppSearch = new TableDefinition(
            "AppSearch",
            new[]
            {
                new ColumnDefinition("Property", ColumnType.String, 72, primaryKey: true, nullable: false, ColumnCategory.Identifier, description: "The property associated with a Signature", modularizeType: ColumnModularizeType.Column),
                new ColumnDefinition("Signature_", ColumnType.String, 72, primaryKey: true, nullable: false, ColumnCategory.Identifier, keyTable: "Signature;RegLocator;IniLocator;DrLocator;CompLocator", keyColumn: 1, description: "The Signature_ represents a unique file signature and is also the foreign key in the Signature,  RegLocator, IniLocator, CompLocator and the DrLocator tables.", modularizeType: ColumnModularizeType.Column),
            },
            tupleDefinitionName: TupleDefinitions.AppSearch.Name,
            tupleIdIsPrimaryKey: false
        );

        public static readonly TableDefinition Property = new TableDefinition(
            "Property",
            new[]
            {
                new ColumnDefinition("Property", ColumnType.String, 72, primaryKey: true, nullable: false, ColumnCategory.Identifier, description: "Name of property, uppercase if settable by launcher or loader.", modularizeType: ColumnModularizeType.Column),
                new ColumnDefinition("Value", ColumnType.Localized, 0, primaryKey: false, nullable: false, ColumnCategory.Text, description: "String value for property.  Never null or empty."),
            },
            tupleDefinitionName: TupleDefinitions.Property.Name,
            tupleIdIsPrimaryKey: true
        );

        public static readonly TableDefinition BBControl = new TableDefinition(
            "BBControl",
            new[]
            {
                new ColumnDefinition("Billboard_", ColumnType.String, 50, primaryKey: true, nullable: false, ColumnCategory.Identifier, keyTable: "Billboard", keyColumn: 1, description: "External key to the Billboard table, name of the billboard.", modularizeType: ColumnModularizeType.Column),
                new ColumnDefinition("BBControl", ColumnType.String, 50, primaryKey: true, nullable: false, ColumnCategory.Identifier, description: "Name of the control. This name must be unique within a billboard, but can repeat on different billboard."),
                new ColumnDefinition("Type", ColumnType.String, 50, primaryKey: false, nullable: false, ColumnCategory.Identifier, description: "The type of the control."),
                new ColumnDefinition("X", ColumnType.Number, 2, primaryKey: false, nullable: false, ColumnCategory.Unknown, minValue: 0, maxValue: 32767, description: "Horizontal coordinate of the upper left corner of the bounding rectangle of the control.", forceLocalizable: true),
                new ColumnDefinition("Y", ColumnType.Number, 2, primaryKey: false, nullable: false, ColumnCategory.Unknown, minValue: 0, maxValue: 32767, description: "Vertical coordinate of the upper left corner of the bounding rectangle of the control.", forceLocalizable: true),
                new ColumnDefinition("Width", ColumnType.Number, 2, primaryKey: false, nullable: false, ColumnCategory.Unknown, minValue: 0, maxValue: 32767, description: "Width of the bounding rectangle of the control.", forceLocalizable: true),
                new ColumnDefinition("Height", ColumnType.Number, 2, primaryKey: false, nullable: false, ColumnCategory.Unknown, minValue: 0, maxValue: 32767, description: "Height of the bounding rectangle of the control.", forceLocalizable: true),
                new ColumnDefinition("Attributes", ColumnType.Number, 4, primaryKey: false, nullable: true, ColumnCategory.Unknown, minValue: 0, maxValue: 2147483647, description: "A 32-bit word that specifies the attribute flags to be applied to this control."),
                new ColumnDefinition("Text", ColumnType.Localized, 50, primaryKey: false, nullable: true, ColumnCategory.Text, description: "A string used to set the initial text contained within a control (if appropriate)."),
            },
            tupleDefinitionName: TupleDefinitions.BBControl.Name,
            tupleIdIsPrimaryKey: false
        );

        public static readonly TableDefinition Billboard = new TableDefinition(
            "Billboard",
            new[]
            {
                new ColumnDefinition("Billboard", ColumnType.String, 50, primaryKey: true, nullable: false, ColumnCategory.Identifier, description: "Name of the billboard.", modularizeType: ColumnModularizeType.Column),
                new ColumnDefinition("Feature_", ColumnType.String, 38, primaryKey: false, nullable: false, ColumnCategory.Identifier, keyTable: "Feature", keyColumn: 1, description: "An external key to the Feature Table. The billboard is shown only if this feature is being installed."),
                new ColumnDefinition("Action", ColumnType.String, 50, primaryKey: false, nullable: true, ColumnCategory.Identifier, description: "The name of an action. The billboard is displayed during the progress messages received from this action."),
                new ColumnDefinition("Ordering", ColumnType.Number, 2, primaryKey: false, nullable: true, ColumnCategory.Unknown, minValue: 0, maxValue: 32767, description: "A positive integer. If there is more than one billboard corresponding to an action they will be shown in the order defined by this column."),
            },
            tupleDefinitionName: TupleDefinitions.Billboard.Name,
            tupleIdIsPrimaryKey: true
        );

        public static readonly TableDefinition Feature = new TableDefinition(
            "Feature",
            new[]
            {
                new ColumnDefinition("Feature", ColumnType.String, 38, primaryKey: true, nullable: false, ColumnCategory.Identifier, description: "Primary key used to identify a particular feature record."),
                new ColumnDefinition("Feature_Parent", ColumnType.String, 38, primaryKey: false, nullable: true, ColumnCategory.Identifier, keyTable: "Feature", keyColumn: 1, description: "Optional key of a parent record in the same table. If the parent is not selected, then the record will not be installed. Null indicates a root item."),
                new ColumnDefinition("Title", ColumnType.Localized, 64, primaryKey: false, nullable: true, ColumnCategory.Text, description: "Short text identifying a visible feature item."),
                new ColumnDefinition("Description", ColumnType.Localized, 255, primaryKey: false, nullable: true, ColumnCategory.Text, description: "Longer descriptive text describing a visible feature item."),
                new ColumnDefinition("Display", ColumnType.Number, 2, primaryKey: false, nullable: true, ColumnCategory.Unknown, minValue: 0, maxValue: 32767, description: "Numeric sort order, used to force a specific display ordering."),
                new ColumnDefinition("Level", ColumnType.Number, 2, primaryKey: false, nullable: false, ColumnCategory.Unknown, minValue: 0, maxValue: 32767, description: "The install level at which record will be initially selected. An install level of 0 will disable an item and prevent its display."),
                new ColumnDefinition("Directory_", ColumnType.String, 72, primaryKey: false, nullable: true, ColumnCategory.UpperCase, keyTable: "Directory", keyColumn: 1, description: "The name of the Directory that can be configured by the UI. A non-null value will enable the browse button.", modularizeType: ColumnModularizeType.Column),
                new ColumnDefinition("Attributes", ColumnType.Number, 2, primaryKey: false, nullable: false, ColumnCategory.Unknown, possibilities: "0;1;2;4;5;6;8;9;10;16;17;18;20;21;22;24;25;26;32;33;34;36;37;38;48;49;50;52;53;54", description: "Feature attributes"),
            },
            tupleDefinitionName: TupleDefinitions.Feature.Name,
            tupleIdIsPrimaryKey: true
        );

        public static readonly TableDefinition Binary = new TableDefinition(
            "Binary",
            new[]
            {
                new ColumnDefinition("Name", ColumnType.String, 72, primaryKey: true, nullable: false, ColumnCategory.Identifier, description: "Unique key identifying the binary data.", modularizeType: ColumnModularizeType.Column),
                new ColumnDefinition("Data", ColumnType.Object, 0, primaryKey: false, nullable: false, ColumnCategory.Binary, description: "The unformatted binary data."),
            },
            tupleDefinitionName: TupleDefinitions.Binary.Name,
            tupleIdIsPrimaryKey: true
        );

        public static readonly TableDefinition BindImage = new TableDefinition(
            "BindImage",
            new[]
            {
                new ColumnDefinition("File_", ColumnType.String, 72, primaryKey: true, nullable: false, ColumnCategory.Identifier, keyTable: "File", keyColumn: 1, description: "The index into the File table. This must be an executable file.", modularizeType: ColumnModularizeType.Column),
                new ColumnDefinition("Path", ColumnType.String, 255, primaryKey: false, nullable: true, ColumnCategory.Paths, description: "A list of ;  delimited paths that represent the paths to be searched for the import DLLS. The list is usually a list of properties each enclosed within square brackets [] .", modularizeType: ColumnModularizeType.Property),
            },
            tupleIdIsPrimaryKey: false
        );

        public static readonly TableDefinition File = new TableDefinition(
            "File",
            new[]
            {
                new ColumnDefinition("File", ColumnType.String, 72, primaryKey: true, nullable: false, ColumnCategory.Identifier, description: "Primary key, non-localized token, must match identifier in cabinet.  For uncompressed files, this field is ignored.", modularizeType: ColumnModularizeType.Column),
                new ColumnDefinition("Component_", ColumnType.String, 72, primaryKey: false, nullable: false, ColumnCategory.Identifier, keyTable: "Component", keyColumn: 1, description: "Foreign key referencing Component that controls the file.", modularizeType: ColumnModularizeType.Column),
                new ColumnDefinition("FileName", ColumnType.Localized, 255, primaryKey: false, nullable: false, ColumnCategory.Filename, description: "File name used for installation, may be localized.  This may contain a \"short name|long name\" pair."),
                new ColumnDefinition("FileSize", ColumnType.Number, 4, primaryKey: false, nullable: false, ColumnCategory.Unknown, minValue: 0, maxValue: 2147483647, description: "Size of file in bytes (long integer)."),
                new ColumnDefinition("Version", ColumnType.String, 72, primaryKey: false, nullable: true, ColumnCategory.Version, keyTable: "File", keyColumn: 1, description: "Version string for versioned files;  Blank for unversioned files.", modularizeType: ColumnModularizeType.CompanionFile),
                new ColumnDefinition("Language", ColumnType.String, 20, primaryKey: false, nullable: true, ColumnCategory.Language, description: "List of decimal language Ids, comma-separated if more than one."),
                new ColumnDefinition("Attributes", ColumnType.Number, 2, primaryKey: false, nullable: true, ColumnCategory.Unknown, minValue: 0, maxValue: 32767, description: "Integer containing bit flags representing file attributes (with the decimal value of each bit position in parentheses)"),
                new ColumnDefinition("Sequence", ColumnType.Number, 4, primaryKey: false, nullable: false, ColumnCategory.Unknown, minValue: 1, maxValue: 2147483647, description: "Sequence with respect to the media images; order must track cabinet order."),
                new ColumnDefinition("DiskId", ColumnType.Number, 4, primaryKey: false, nullable: false, ColumnCategory.Unknown, minValue: 1, maxValue: 32767, description: "Disk identifier for the file.", unreal: true),
                new ColumnDefinition("Source", ColumnType.Object, 0, primaryKey: false, nullable: false, ColumnCategory.Binary, description: "Path to source of file.", unreal: true),
            },
            tupleDefinitionName: TupleDefinitions.File.Name,
            tupleIdIsPrimaryKey: true
        );

        public static readonly TableDefinition CCPSearch = new TableDefinition(
            "CCPSearch",
            new[]
            {
                new ColumnDefinition("Signature_", ColumnType.String, 72, primaryKey: true, nullable: false, ColumnCategory.Identifier, keyTable: "Signature;RegLocator;IniLocator;DrLocator;CompLocator", keyColumn: 1, description: "The Signature_ represents a unique file signature and is also the foreign key in the Signature,  RegLocator, IniLocator, CompLocator and the DrLocator tables."),
            },
            tupleDefinitionName: TupleDefinitions.CCPSearch.Name,
            tupleIdIsPrimaryKey: true
        );

        public static readonly TableDefinition CheckBox = new TableDefinition(
            "CheckBox",
            new[]
            {
                new ColumnDefinition("Property", ColumnType.String, 72, primaryKey: true, nullable: false, ColumnCategory.Identifier, description: "A named property to be tied to the item.", modularizeType: ColumnModularizeType.Column),
                new ColumnDefinition("Value", ColumnType.String, 64, primaryKey: false, nullable: true, ColumnCategory.Formatted, description: "The value string associated with the item.", modularizeType: ColumnModularizeType.Property),
            },
            tupleDefinitionName: TupleDefinitions.CheckBox.Name,
            tupleIdIsPrimaryKey: false
        );

        public static readonly TableDefinition Class = new TableDefinition(
            "Class",
            new[]
            {
                new ColumnDefinition("CLSID", ColumnType.String, 38, primaryKey: true, nullable: false, ColumnCategory.Guid, description: "The CLSID of an OLE factory."),
                new ColumnDefinition("Context", ColumnType.String, 32, primaryKey: true, nullable: false, ColumnCategory.Identifier, description: "The numeric server context for this server. CLSCTX_xxxx"),
                new ColumnDefinition("Component_", ColumnType.String, 72, primaryKey: true, nullable: false, ColumnCategory.Identifier, keyTable: "Component", keyColumn: 1, description: "Required foreign key into the Component Table, specifying the component for which to return a path when called through LocateComponent.", modularizeType: ColumnModularizeType.Column),
                new ColumnDefinition("ProgId_Default", ColumnType.String, 255, primaryKey: false, nullable: true, ColumnCategory.Text, keyTable: "ProgId", keyColumn: 1, description: "Optional ProgId associated with this CLSID."),
                new ColumnDefinition("Description", ColumnType.Localized, 255, primaryKey: false, nullable: true, ColumnCategory.Text, description: "Localized description for the Class."),
                new ColumnDefinition("AppId_", ColumnType.String, 38, primaryKey: false, nullable: true, ColumnCategory.Guid, keyTable: "AppId", keyColumn: 1, description: "Optional AppID containing DCOM information for associated application (string GUID)."),
                new ColumnDefinition("FileTypeMask", ColumnType.String, 255, primaryKey: false, nullable: true, ColumnCategory.Text, description: "Optional string containing information for the HKCRthis CLSID) key. If multiple patterns exist, they must be delimited by a semicolon, and numeric subkeys will be generated: 0,1,2..."),
                new ColumnDefinition("Icon_", ColumnType.String, 72, primaryKey: false, nullable: true, ColumnCategory.Identifier, keyTable: "Icon", keyColumn: 1, description: "Optional foreign key into the Icon Table, specifying the icon file associated with this CLSID. Will be written under the DefaultIcon key.", modularizeType: ColumnModularizeType.Icon),
                new ColumnDefinition("IconIndex", ColumnType.Number, 2, primaryKey: false, nullable: true, ColumnCategory.Unknown, minValue: -32767, maxValue: 32767, description: "Optional icon index."),
                new ColumnDefinition("DefInprocHandler", ColumnType.String, 32, primaryKey: false, nullable: true, ColumnCategory.Filename, possibilities: "1;2;3", description: "Optional default inproc handler.  Only optionally provided if Context=CLSCTX_LOCAL_SERVER.  Typically \"ole32.dll\" or \"mapi32.dll\""),
                new ColumnDefinition("Argument", ColumnType.String, 255, primaryKey: false, nullable: true, ColumnCategory.Formatted, description: "optional argument for LocalServers."),
                new ColumnDefinition("Feature_", ColumnType.String, 38, primaryKey: false, nullable: false, ColumnCategory.Identifier, keyTable: "Feature", keyColumn: 1, description: "Required foreign key into the Feature Table, specifying the feature to validate or install in order for the CLSID factory to be operational."),
                new ColumnDefinition("Attributes", ColumnType.Number, 2, primaryKey: false, nullable: true, ColumnCategory.Unknown, maxValue: 32767, description: "Class registration attributes."),
            },
            tupleDefinitionName: TupleDefinitions.Class.Name,
            tupleIdIsPrimaryKey: false
        );

        public static readonly TableDefinition Component = new TableDefinition(
            "Component",
            new[]
            {
                new ColumnDefinition("Component", ColumnType.String, 72, primaryKey: true, nullable: false, ColumnCategory.Identifier, description: "Primary key used to identify a particular component record.", modularizeType: ColumnModularizeType.Column),
                new ColumnDefinition("ComponentId", ColumnType.String, 38, primaryKey: false, nullable: true, ColumnCategory.Guid, description: "A string GUID unique to this component, version, and language."),
                new ColumnDefinition("Directory_", ColumnType.String, 72, primaryKey: false, nullable: false, ColumnCategory.Identifier, keyTable: "Directory", keyColumn: 1, description: "Required key of a Directory table record. This is actually a property name whose value contains the actual path, set either by the AppSearch action or with the default setting obtained from the Directory table.", modularizeType: ColumnModularizeType.Column),
                new ColumnDefinition("Attributes", ColumnType.Number, 2, primaryKey: false, nullable: false, ColumnCategory.Unknown, description: "Remote execution option, one of irsEnum"),
                new ColumnDefinition("Condition", ColumnType.String, 255, primaryKey: false, nullable: true, ColumnCategory.Condition, description: "A conditional statement that will disable this component if the specified condition evaluates to the 'True' state. If a component is disabled, it will not be installed, regardless of the 'Action' state associated with the component.", modularizeType: ColumnModularizeType.Condition, forceLocalizable: true),
                new ColumnDefinition("KeyPath", ColumnType.String, 72, primaryKey: false, nullable: true, ColumnCategory.Identifier, keyTable: "File;Registry;ODBCDataSource", keyColumn: 1, description: "Either the primary key into the File table, Registry table, or ODBCDataSource table. This extract path is stored when the component is installed, and is used to detect the presence of the component and to return the path to it.", modularizeType: ColumnModularizeType.Column),
            },
            tupleDefinitionName: TupleDefinitions.Component.Name,
            tupleIdIsPrimaryKey: true
        );

        public static readonly TableDefinition Icon = new TableDefinition(
            "Icon",
            new[]
            {
                new ColumnDefinition("Name", ColumnType.String, 72, primaryKey: true, nullable: false, ColumnCategory.Identifier, description: "Primary key. Name of the icon file.", modularizeType: ColumnModularizeType.Icon),
                new ColumnDefinition("Data", ColumnType.Object, 0, primaryKey: false, nullable: false, ColumnCategory.Binary, description: "Binary stream. The binary icon data in PE (.DLL or .EXE) or icon (.ICO) format."),
            },
            tupleDefinitionName: TupleDefinitions.Icon.Name,
            tupleIdIsPrimaryKey: true
        );

        public static readonly TableDefinition ProgId = new TableDefinition(
            "ProgId",
            new[]
            {
                new ColumnDefinition("ProgId", ColumnType.String, 255, primaryKey: true, nullable: false, ColumnCategory.Text, description: "The Program Identifier. Primary key."),
                new ColumnDefinition("ProgId_Parent", ColumnType.String, 255, primaryKey: false, nullable: true, ColumnCategory.Text, keyTable: "ProgId", keyColumn: 1, description: "The Parent Program Identifier. If specified, the ProgId column becomes a version independent prog id."),
                new ColumnDefinition("Class_", ColumnType.String, 38, primaryKey: false, nullable: true, ColumnCategory.Guid, keyTable: "Class", keyColumn: 1, description: "The CLSID of an OLE factory corresponding to the ProgId."),
                new ColumnDefinition("Description", ColumnType.Localized, 255, primaryKey: false, nullable: true, ColumnCategory.Text, description: "Localized description for the Program identifier."),
                new ColumnDefinition("Icon_", ColumnType.String, 72, primaryKey: false, nullable: true, ColumnCategory.Identifier, keyTable: "Icon", keyColumn: 1, description: "Optional foreign key into the Icon Table, specifying the icon file associated with this ProgId. Will be written under the DefaultIcon key.", modularizeType: ColumnModularizeType.Icon),
                new ColumnDefinition("IconIndex", ColumnType.Number, 2, primaryKey: false, nullable: true, ColumnCategory.Unknown, minValue: -32767, maxValue: 32767, description: "Optional icon index."),
            },
            tupleDefinitionName: TupleDefinitions.ProgId.Name,
            tupleIdIsPrimaryKey: false
        );

        public static readonly TableDefinition ComboBox = new TableDefinition(
            "ComboBox",
            new[]
            {
                new ColumnDefinition("Property", ColumnType.String, 72, primaryKey: true, nullable: false, ColumnCategory.Identifier, description: "A named property to be tied to this item. All the items tied to the same property become part of the same combobox.", modularizeType: ColumnModularizeType.Column),
                new ColumnDefinition("Order", ColumnType.Number, 2, primaryKey: true, nullable: false, ColumnCategory.Unknown, minValue: 1, maxValue: 32767, description: "A positive integer used to determine the ordering of the items within one list. The integers do not have to be consecutive."),
                new ColumnDefinition("Value", ColumnType.String, 64, primaryKey: false, nullable: false, ColumnCategory.Formatted, description: "The value string associated with this item. Selecting the line will set the associated property to this value.", modularizeType: ColumnModularizeType.Property, forceLocalizable: true),
                new ColumnDefinition("Text", ColumnType.Localized, 64, primaryKey: false, nullable: true, ColumnCategory.Formatted, description: "The visible text to be assigned to the item. Optional. If this entry or the entire column is missing, the text is the same as the value.", modularizeType: ColumnModularizeType.Property),
            },
            tupleDefinitionName: TupleDefinitions.ComboBox.Name,
            tupleIdIsPrimaryKey: false
        );

        public static readonly TableDefinition CompLocator = new TableDefinition(
            "CompLocator",
            new[]
            {
                new ColumnDefinition("Signature_", ColumnType.String, 72, primaryKey: true, nullable: false, ColumnCategory.Identifier, description: "The table key. The Signature_ represents a unique file signature and is also the foreign key in the Signature table.", modularizeType: ColumnModularizeType.Column),
                new ColumnDefinition("ComponentId", ColumnType.String, 38, primaryKey: false, nullable: false, ColumnCategory.Guid, description: "A string GUID unique to this component, version, and language."),
                new ColumnDefinition("Type", ColumnType.Number, 2, primaryKey: false, nullable: true, ColumnCategory.Unknown, minValue: 0, maxValue: 1, description: "A boolean value that determines if the registry value is a filename or a directory location."),
            },
            tupleDefinitionName: TupleDefinitions.CompLocator.Name,
            tupleIdIsPrimaryKey: false
        );

        public static readonly TableDefinition Complus = new TableDefinition(
            "Complus",
            new[]
            {
                new ColumnDefinition("Component_", ColumnType.String, 72, primaryKey: true, nullable: false, ColumnCategory.Identifier, keyTable: "Component", keyColumn: 1, description: "Foreign key referencing Component that controls the ComPlus component.", modularizeType: ColumnModularizeType.Column),
                new ColumnDefinition("ExpType", ColumnType.Number, 2, primaryKey: false, nullable: true, ColumnCategory.Unknown, minValue: 0, maxValue: 32767, description: "ComPlus component attributes."),
            },
            tupleDefinitionName: TupleDefinitions.Complus.Name,
            tupleIdIsPrimaryKey: false
        );

        public static readonly TableDefinition Directory = new TableDefinition(
            "Directory",
            new[]
            {
                new ColumnDefinition("Directory", ColumnType.String, 72, primaryKey: true, nullable: false, ColumnCategory.Identifier, description: "Unique identifier for directory entry, primary key. If a property by this name is defined, it contains the full path to the directory.", modularizeType: ColumnModularizeType.Column),
                new ColumnDefinition("Directory_Parent", ColumnType.String, 72, primaryKey: false, nullable: true, ColumnCategory.Identifier, keyTable: "Directory", keyColumn: 1, description: "Reference to the entry in this table specifying the default parent directory. A record parented to itself or with a Null parent represents a root of the install tree.", modularizeType: ColumnModularizeType.Column),
                new ColumnDefinition("DefaultDir", ColumnType.Localized, 255, primaryKey: false, nullable: false, ColumnCategory.DefaultDir, description: "The default sub-path under parent's path."),
            },
            tupleDefinitionName: TupleDefinitions.Directory.Name,
            tupleIdIsPrimaryKey: true
        );

        public static readonly TableDefinition Control = new TableDefinition(
            "Control",
            new[]
            {
                new ColumnDefinition("Dialog_", ColumnType.String, 72, primaryKey: true, nullable: false, ColumnCategory.Identifier, keyTable: "Dialog", keyColumn: 1, description: "External key to the Dialog table, name of the dialog.", modularizeType: ColumnModularizeType.Column),
                new ColumnDefinition("Control", ColumnType.String, 50, primaryKey: true, nullable: false, ColumnCategory.Identifier, description: "Name of the control. This name must be unique within a dialog, but can repeat on different dialogs. "),
                new ColumnDefinition("Type", ColumnType.String, 20, primaryKey: false, nullable: false, ColumnCategory.Identifier, description: "The type of the control."),
                new ColumnDefinition("X", ColumnType.Number, 2, primaryKey: false, nullable: false, ColumnCategory.Unknown, minValue: 0, maxValue: 32767, description: "Horizontal coordinate of the upper left corner of the bounding rectangle of the control.", forceLocalizable: true),
                new ColumnDefinition("Y", ColumnType.Number, 2, primaryKey: false, nullable: false, ColumnCategory.Unknown, minValue: 0, maxValue: 32767, description: "Vertical coordinate of the upper left corner of the bounding rectangle of the control.", forceLocalizable: true),
                new ColumnDefinition("Width", ColumnType.Number, 2, primaryKey: false, nullable: false, ColumnCategory.Unknown, minValue: 0, maxValue: 32767, description: "Width of the bounding rectangle of the control.", forceLocalizable: true),
                new ColumnDefinition("Height", ColumnType.Number, 2, primaryKey: false, nullable: false, ColumnCategory.Unknown, minValue: 0, maxValue: 32767, description: "Height of the bounding rectangle of the control.", forceLocalizable: true),
                new ColumnDefinition("Attributes", ColumnType.Number, 4, primaryKey: false, nullable: true, ColumnCategory.Unknown, minValue: 0, maxValue: 2147483647, description: "A 32-bit word that specifies the attribute flags to be applied to this control."),
                new ColumnDefinition("Property", ColumnType.String, 72, primaryKey: false, nullable: true, ColumnCategory.Identifier, description: "The name of a defined property to be linked to this control. ", modularizeType: ColumnModularizeType.Column),
                new ColumnDefinition("Text", ColumnType.Localized, 0, primaryKey: false, nullable: true, ColumnCategory.Formatted, description: "A string used to set the initial text contained within a control (if appropriate).", modularizeType: ColumnModularizeType.ControlText),
                new ColumnDefinition("Control_Next", ColumnType.String, 50, primaryKey: false, nullable: true, ColumnCategory.Identifier, keyTable: "Control", keyColumn: 2, description: "The name of an other control on the same dialog. This link defines the tab order of the controls. The links have to form one or more cycles!"),
                new ColumnDefinition("Help", ColumnType.Localized, 50, primaryKey: false, nullable: true, ColumnCategory.Text, description: "The help strings used with the button. The text is optional. "),
            },
            tupleDefinitionName: TupleDefinitions.Control.Name,
            tupleIdIsPrimaryKey: false
        );

        public static readonly TableDefinition Dialog = new TableDefinition(
            "Dialog",
            new[]
            {
                new ColumnDefinition("Dialog", ColumnType.String, 72, primaryKey: true, nullable: false, ColumnCategory.Identifier, description: "Name of the dialog.", modularizeType: ColumnModularizeType.Column),
                new ColumnDefinition("HCentering", ColumnType.Number, 2, primaryKey: false, nullable: false, ColumnCategory.Unknown, minValue: 0, maxValue: 100, description: "Horizontal position of the dialog on a 0-100 scale. 0 means left end, 100 means right end of the screen, 50 center."),
                new ColumnDefinition("VCentering", ColumnType.Number, 2, primaryKey: false, nullable: false, ColumnCategory.Unknown, minValue: 0, maxValue: 100, description: "Vertical position of the dialog on a 0-100 scale. 0 means top end, 100 means bottom end of the screen, 50 center."),
                new ColumnDefinition("Width", ColumnType.Number, 2, primaryKey: false, nullable: false, ColumnCategory.Unknown, minValue: 0, maxValue: 32767, description: "Width of the bounding rectangle of the dialog."),
                new ColumnDefinition("Height", ColumnType.Number, 2, primaryKey: false, nullable: false, ColumnCategory.Unknown, minValue: 0, maxValue: 32767, description: "Height of the bounding rectangle of the dialog."),
                new ColumnDefinition("Attributes", ColumnType.Number, 4, primaryKey: false, nullable: true, ColumnCategory.Unknown, minValue: 0, maxValue: 2147483647, description: "A 32-bit word that specifies the attribute flags to be applied to this dialog."),
                new ColumnDefinition("Title", ColumnType.Localized, 128, primaryKey: false, nullable: true, ColumnCategory.Formatted, description: "A text string specifying the title to be displayed in the title bar of the dialog's window.", modularizeType: ColumnModularizeType.Property),
                new ColumnDefinition("Control_First", ColumnType.String, 50, primaryKey: false, nullable: false, ColumnCategory.Identifier, keyTable: "Control", keyColumn: 2, description: "Defines the control that has the focus when the dialog is created."),
                new ColumnDefinition("Control_Default", ColumnType.String, 50, primaryKey: false, nullable: true, ColumnCategory.Identifier, keyTable: "Control", keyColumn: 2, description: "Defines the default control. Hitting return is equivalent to pushing this button."),
                new ColumnDefinition("Control_Cancel", ColumnType.String, 50, primaryKey: false, nullable: true, ColumnCategory.Identifier, keyTable: "Control", keyColumn: 2, description: "Defines the cancel control. Hitting escape or clicking on the close icon on the dialog is equivalent to pushing this button."),
            },
            tupleDefinitionName: TupleDefinitions.Dialog.Name,
            tupleIdIsPrimaryKey: true
        );

        public static readonly TableDefinition ControlCondition = new TableDefinition(
            "ControlCondition",
            new[]
            {
                new ColumnDefinition("Dialog_", ColumnType.String, 72, primaryKey: true, nullable: false, ColumnCategory.Identifier, keyTable: "Dialog", keyColumn: 1, description: "A foreign key to the Dialog table, name of the dialog.", modularizeType: ColumnModularizeType.Column),
                new ColumnDefinition("Control_", ColumnType.String, 50, primaryKey: true, nullable: false, ColumnCategory.Identifier, keyTable: "Control", keyColumn: 2, description: "A foreign key to the Control table, name of the control."),
                new ColumnDefinition("Action", ColumnType.String, 50, primaryKey: true, nullable: false, ColumnCategory.Unknown, possibilities: "Default;Disable;Enable;Hide;Show", description: "The desired action to be taken on the specified control."),
                new ColumnDefinition("Condition", ColumnType.String, 255, primaryKey: true, nullable: false, ColumnCategory.Condition, description: "A standard conditional statement that specifies under which conditions the action should be triggered.", modularizeType: ColumnModularizeType.Condition, forceLocalizable: true),
            },
            tupleDefinitionName: TupleDefinitions.ControlCondition.Name,
            tupleIdIsPrimaryKey: false
        );

        public static readonly TableDefinition ControlEvent = new TableDefinition(
            "ControlEvent",
            new[]
            {
                new ColumnDefinition("Dialog_", ColumnType.String, 72, primaryKey: true, nullable: false, ColumnCategory.Identifier, keyTable: "Dialog", keyColumn: 1, description: "A foreign key to the Dialog table, name of the dialog.", modularizeType: ColumnModularizeType.Column),
                new ColumnDefinition("Control_", ColumnType.String, 50, primaryKey: true, nullable: false, ColumnCategory.Identifier, keyTable: "Control", keyColumn: 2, description: "A foreign key to the Control table, name of the control"),
                new ColumnDefinition("Event", ColumnType.String, 50, primaryKey: true, nullable: false, ColumnCategory.Formatted, description: "An identifier that specifies the type of the event that should take place when the user interacts with control specified by the first two entries.", modularizeType: ColumnModularizeType.Property),
                new ColumnDefinition("Argument", ColumnType.String, 255, primaryKey: true, nullable: false, ColumnCategory.Formatted, description: "A value to be used as a modifier when triggering a particular event.", modularizeType: ColumnModularizeType.ControlEventArgument, forceLocalizable: true),
                new ColumnDefinition("Condition", ColumnType.String, 255, primaryKey: true, nullable: true, ColumnCategory.Condition, description: "A standard conditional statement that specifies under which conditions an event should be triggered.", modularizeType: ColumnModularizeType.Condition, forceLocalizable: true),
                new ColumnDefinition("Ordering", ColumnType.Number, 2, primaryKey: false, nullable: true, ColumnCategory.Unknown, minValue: 0, maxValue: 2147483647, description: "An integer used to order several events tied to the same control. Can be left blank."),
            },
            tupleDefinitionName: TupleDefinitions.ControlEvent.Name,
            tupleIdIsPrimaryKey: false
        );

        public static readonly TableDefinition CreateFolder = new TableDefinition(
            "CreateFolder",
            new[]
            {
                new ColumnDefinition("Directory_", ColumnType.String, 72, primaryKey: true, nullable: false, ColumnCategory.Identifier, keyTable: "Directory", keyColumn: 1, description: "Primary key, could be foreign key into the Directory table.", modularizeType: ColumnModularizeType.Column),
                new ColumnDefinition("Component_", ColumnType.String, 72, primaryKey: true, nullable: false, ColumnCategory.Identifier, keyTable: "Component", keyColumn: 1, description: "Foreign key into the Component table.", modularizeType: ColumnModularizeType.Column),
            },
            tupleDefinitionName: TupleDefinitions.CreateFolder.Name,
            tupleIdIsPrimaryKey: false
        );

        public static readonly TableDefinition CustomAction = new TableDefinition(
            "CustomAction",
            new[]
            {
                new ColumnDefinition("Action", ColumnType.String, 72, primaryKey: true, nullable: false, ColumnCategory.Identifier, description: "Primary key, name of action, normally appears in sequence table unless private use.", modularizeType: ColumnModularizeType.Column),
                new ColumnDefinition("Type", ColumnType.Number, 2, primaryKey: false, nullable: false, ColumnCategory.Unknown, minValue: 1, maxValue: 32767, description: "The numeric custom action type, consisting of source location, code type, entry, option flags."),
                new ColumnDefinition("Source", ColumnType.String, 72, primaryKey: false, nullable: true, ColumnCategory.CustomSource, description: "The table reference of the source of the code.", modularizeType: ColumnModularizeType.Column),
                new ColumnDefinition("Target", ColumnType.String, 255, primaryKey: false, nullable: true, ColumnCategory.Formatted, description: "Excecution parameter, depends on the type of custom action", modularizeType: ColumnModularizeType.Property, forceLocalizable: true),
                new ColumnDefinition("ExtendedType", ColumnType.Number, 4, primaryKey: false, nullable: true, ColumnCategory.Unknown, minValue: 0, maxValue: 2147483647, description: "A numeric custom action type that extends code type or option flags of the Type column."),
            },
            tupleDefinitionName: TupleDefinitions.CustomAction.Name,
            tupleIdIsPrimaryKey: true
        );

        public static readonly TableDefinition DrLocator = new TableDefinition(
            "DrLocator",
            new[]
            {
                new ColumnDefinition("Signature_", ColumnType.String, 72, primaryKey: true, nullable: false, ColumnCategory.Identifier, description: "The Signature_ represents a unique file signature and is also the foreign key in the Signature table.", modularizeType: ColumnModularizeType.Column),
                new ColumnDefinition("Parent", ColumnType.String, 72, primaryKey: true, nullable: true, ColumnCategory.Identifier, description: "The parent file signature. It is also a foreign key in the Signature table. If null and the Path column does not expand to a full path, then all the fixed drives of the user system are searched using the Path.", modularizeType: ColumnModularizeType.Column),
                new ColumnDefinition("Path", ColumnType.String, 255, primaryKey: true, nullable: true, ColumnCategory.AnyPath, description: "The path on the user system. This is a either a subpath below the value of the Parent or a full path. The path may contain properties enclosed within [ ] that will be expanded.", modularizeType: ColumnModularizeType.Property),
                new ColumnDefinition("Depth", ColumnType.Number, 2, primaryKey: false, nullable: true, ColumnCategory.Unknown, minValue: 0, maxValue: 32767, description: "The depth below the path to which the Signature_ is recursively searched. If absent, the depth is assumed to be 0."),
            },
            tupleDefinitionName: TupleDefinitions.DrLocator.Name,
            tupleIdIsPrimaryKey: false
        );

        public static readonly TableDefinition DuplicateFile = new TableDefinition(
            "DuplicateFile",
            new[]
            {
                new ColumnDefinition("FileKey", ColumnType.String, 72, primaryKey: true, nullable: false, ColumnCategory.Identifier, description: "Primary key used to identify a particular file entry", modularizeType: ColumnModularizeType.Column),
                new ColumnDefinition("Component_", ColumnType.String, 72, primaryKey: false, nullable: false, ColumnCategory.Identifier, keyTable: "Component", keyColumn: 1, description: "Foreign key referencing Component that controls the duplicate file.", modularizeType: ColumnModularizeType.Column),
                new ColumnDefinition("File_", ColumnType.String, 72, primaryKey: false, nullable: false, ColumnCategory.Identifier, keyTable: "File", keyColumn: 1, description: "Foreign key referencing the source file to be duplicated.", modularizeType: ColumnModularizeType.Column),
                new ColumnDefinition("DestName", ColumnType.Localized, 255, primaryKey: false, nullable: true, ColumnCategory.Filename, description: "Filename to be given to the duplicate file."),
                new ColumnDefinition("DestFolder", ColumnType.String, 72, primaryKey: false, nullable: true, ColumnCategory.Identifier, description: "Name of a property whose value is assumed to resolve to the full pathname to a destination folder.", modularizeType: ColumnModularizeType.Column),
            },
            tupleDefinitionName: TupleDefinitions.DuplicateFile.Name,
            tupleIdIsPrimaryKey: true
        );

        public static readonly TableDefinition Environment = new TableDefinition(
            "Environment",
            new[]
            {
                new ColumnDefinition("Environment", ColumnType.String, 72, primaryKey: true, nullable: false, ColumnCategory.Identifier, description: "Unique identifier for the environmental variable setting", modularizeType: ColumnModularizeType.Column),
                new ColumnDefinition("Name", ColumnType.Localized, 255, primaryKey: false, nullable: false, ColumnCategory.Text, description: "The name of the environmental value."),
                new ColumnDefinition("Value", ColumnType.Localized, 255, primaryKey: false, nullable: true, ColumnCategory.Formatted, description: "The value to set in the environmental settings.", modularizeType: ColumnModularizeType.Property),
                new ColumnDefinition("Component_", ColumnType.String, 72, primaryKey: false, nullable: false, ColumnCategory.Identifier, keyTable: "Component", keyColumn: 1, description: "Foreign key into the Component table referencing component that controls the installing of the environmental value.", modularizeType: ColumnModularizeType.Column),
            },
            tupleDefinitionName: TupleDefinitions.Environment.Name,
            tupleIdIsPrimaryKey: true
        );

        public static readonly TableDefinition Error = new TableDefinition(
            "Error",
            new[]
            {
                new ColumnDefinition("Error", ColumnType.Number, 2, primaryKey: true, nullable: false, ColumnCategory.Unknown, minValue: 0, maxValue: 32767, description: "Integer error number, obtained from header file IError(...) macros."),
                new ColumnDefinition("Message", ColumnType.Localized, 0, primaryKey: false, nullable: true, ColumnCategory.Template, description: "Error formatting template, obtained from user ed. or localizers.", modularizeType: ColumnModularizeType.Property, useCData: true),
            },
            tupleDefinitionName: TupleDefinitions.Error.Name,
            tupleIdIsPrimaryKey: true
        );

        public static readonly TableDefinition EventMapping = new TableDefinition(
            "EventMapping",
            new[]
            {
                new ColumnDefinition("Dialog_", ColumnType.String, 72, primaryKey: true, nullable: false, ColumnCategory.Identifier, keyTable: "Dialog", keyColumn: 1, description: "A foreign key to the Dialog table, name of the Dialog.", modularizeType: ColumnModularizeType.Column),
                new ColumnDefinition("Control_", ColumnType.String, 50, primaryKey: true, nullable: false, ColumnCategory.Identifier, keyTable: "Control", keyColumn: 2, description: "A foreign key to the Control table, name of the control."),
                new ColumnDefinition("Event", ColumnType.String, 50, primaryKey: true, nullable: false, ColumnCategory.Identifier, description: "An identifier that specifies the type of the event that the control subscribes to."),
                new ColumnDefinition("Attribute", ColumnType.String, 50, primaryKey: false, nullable: false, ColumnCategory.Identifier, description: "The name of the control attribute, that is set when this event is received."),
            },
            tupleDefinitionName: TupleDefinitions.EventMapping.Name,
            tupleIdIsPrimaryKey: false
        );

        public static readonly TableDefinition Extension = new TableDefinition(
            "Extension",
            new[]
            {
                new ColumnDefinition("Extension", ColumnType.String, 255, primaryKey: true, nullable: false, ColumnCategory.Text, description: "The extension associated with the table row."),
                new ColumnDefinition("Component_", ColumnType.String, 72, primaryKey: true, nullable: false, ColumnCategory.Identifier, keyTable: "Component", keyColumn: 1, description: "Required foreign key into the Component Table, specifying the component for which to return a path when called through LocateComponent.", modularizeType: ColumnModularizeType.Column),
                new ColumnDefinition("ProgId_", ColumnType.String, 255, primaryKey: false, nullable: true, ColumnCategory.Text, keyTable: "ProgId", keyColumn: 1, description: "Optional ProgId associated with this extension."),
                new ColumnDefinition("MIME_", ColumnType.String, 64, primaryKey: false, nullable: true, ColumnCategory.Text, keyTable: "MIME", keyColumn: 1, description: "Optional Context identifier, typically \"type/format\" associated with the extension"),
                new ColumnDefinition("Feature_", ColumnType.String, 38, primaryKey: false, nullable: false, ColumnCategory.Identifier, keyTable: "Feature", keyColumn: 1, description: "Required foreign key into the Feature Table, specifying the feature to validate or install in order for the CLSID factory to be operational."),
            },
            tupleDefinitionName: TupleDefinitions.Extension.Name,
            tupleIdIsPrimaryKey: false
        );

        public static readonly TableDefinition MIME = new TableDefinition(
            "MIME",
            new[]
            {
                new ColumnDefinition("ContentType", ColumnType.String, 64, primaryKey: true, nullable: false, ColumnCategory.Text, description: "Primary key. Context identifier, typically \"type/format\"."),
                new ColumnDefinition("Extension_", ColumnType.String, 255, primaryKey: false, nullable: false, ColumnCategory.Text, keyTable: "Extension", keyColumn: 1, description: "Optional associated extension (without dot)"),
                new ColumnDefinition("CLSID", ColumnType.String, 38, primaryKey: false, nullable: true, ColumnCategory.Guid, description: "Optional associated CLSID."),
            },
            tupleDefinitionName: TupleDefinitions.MIME.Name,
            tupleIdIsPrimaryKey: false
        );

        public static readonly TableDefinition FeatureComponents = new TableDefinition(
            "FeatureComponents",
            new[]
            {
                new ColumnDefinition("Feature_", ColumnType.String, 38, primaryKey: true, nullable: false, ColumnCategory.Identifier, keyTable: "Feature", keyColumn: 1, description: "Foreign key into Feature table."),
                new ColumnDefinition("Component_", ColumnType.String, 72, primaryKey: true, nullable: false, ColumnCategory.Identifier, keyTable: "Component", keyColumn: 1, description: "Foreign key into Component table.", modularizeType: ColumnModularizeType.Column),
            },
            tupleDefinitionName: TupleDefinitions.FeatureComponents.Name,
            tupleIdIsPrimaryKey: false
        );

        public static readonly TableDefinition FileSFPCatalog = new TableDefinition(
            "FileSFPCatalog",
            new[]
            {
                new ColumnDefinition("File_", ColumnType.String, 72, primaryKey: true, nullable: false, ColumnCategory.Identifier, keyTable: "File", keyColumn: 1, description: "File associated with the catalog", modularizeType: ColumnModularizeType.Column),
                new ColumnDefinition("SFPCatalog_", ColumnType.String, 255, primaryKey: true, nullable: false, ColumnCategory.Filename, keyTable: "SFPCatalog", keyColumn: 1, description: "Catalog associated with the file"),
            },
            tupleDefinitionName: TupleDefinitions.FileSFPCatalog.Name,
            tupleIdIsPrimaryKey: false
        );

        public static readonly TableDefinition SFPCatalog = new TableDefinition(
            "SFPCatalog",
            new[]
            {
                new ColumnDefinition("SFPCatalog", ColumnType.String, 255, primaryKey: true, nullable: false, ColumnCategory.Filename, description: "File name for the catalog."),
                new ColumnDefinition("Catalog", ColumnType.Object, 0, primaryKey: false, nullable: false, ColumnCategory.Binary, description: "SFP Catalog"),
                new ColumnDefinition("Dependency", ColumnType.String, 0, primaryKey: false, nullable: true, ColumnCategory.Formatted, description: "Parent catalog - only used by SFP", modularizeType: ColumnModularizeType.Property),
            },
            tupleDefinitionName: TupleDefinitions.SFPCatalog.Name,
            tupleIdIsPrimaryKey: false
        );

        public static readonly TableDefinition Font = new TableDefinition(
            "Font",
            new[]
            {
                new ColumnDefinition("File_", ColumnType.String, 72, primaryKey: true, nullable: false, ColumnCategory.Identifier, keyTable: "File", keyColumn: 1, description: "Primary key, foreign key into File table referencing font file.", modularizeType: ColumnModularizeType.Column),
                new ColumnDefinition("FontTitle", ColumnType.String, 128, primaryKey: false, nullable: true, ColumnCategory.Text, description: "Font name."),
            },
            tupleIdIsPrimaryKey: false
        );

        public static readonly TableDefinition IniFile = new TableDefinition(
            "IniFile",
            new[]
            {
                new ColumnDefinition("IniFile", ColumnType.String, 72, primaryKey: true, nullable: false, ColumnCategory.Identifier, description: "Primary key, non-localized token.", modularizeType: ColumnModularizeType.Column),
                new ColumnDefinition("FileName", ColumnType.Localized, 255, primaryKey: false, nullable: false, ColumnCategory.Filename, description: "The .INI file name in which to write the information"),
                new ColumnDefinition("DirProperty", ColumnType.String, 72, primaryKey: false, nullable: true, ColumnCategory.Identifier, description: "Foreign key into the Directory table denoting the directory where the .INI file is.", modularizeType: ColumnModularizeType.Column),
                new ColumnDefinition("Section", ColumnType.Localized, 96, primaryKey: false, nullable: false, ColumnCategory.Formatted, description: "The .INI file Section.", modularizeType: ColumnModularizeType.Property),
                new ColumnDefinition("Key", ColumnType.Localized, 128, primaryKey: false, nullable: false, ColumnCategory.Formatted, description: "The .INI file key below Section.", modularizeType: ColumnModularizeType.Property),
                new ColumnDefinition("Value", ColumnType.Localized, 255, primaryKey: false, nullable: false, ColumnCategory.Formatted, description: "The value to be written.", modularizeType: ColumnModularizeType.Property),
                new ColumnDefinition("Action", ColumnType.Number, 2, primaryKey: false, nullable: false, ColumnCategory.Unknown, possibilities: "0;1;3", description: "The type of modification to be made, one of iifEnum"),
                new ColumnDefinition("Component_", ColumnType.String, 72, primaryKey: false, nullable: false, ColumnCategory.Identifier, keyTable: "Component", keyColumn: 1, description: "Foreign key into the Component table referencing component that controls the installing of the .INI value.", modularizeType: ColumnModularizeType.Column),
            },
            tupleDefinitionName: TupleDefinitions.IniFile.Name,
            tupleIdIsPrimaryKey: true
        );

        public static readonly TableDefinition IniLocator = new TableDefinition(
            "IniLocator",
            new[]
            {
                new ColumnDefinition("Signature_", ColumnType.String, 72, primaryKey: true, nullable: false, ColumnCategory.Identifier, description: "The table key. The Signature_ represents a unique file signature and is also the foreign key in the Signature table.", modularizeType: ColumnModularizeType.Column),
                new ColumnDefinition("FileName", ColumnType.String, 255, primaryKey: false, nullable: false, ColumnCategory.Filename, description: "The .INI file name."),
                new ColumnDefinition("Section", ColumnType.String, 96, primaryKey: false, nullable: false, ColumnCategory.Text, description: "Section name within in file (within square brackets in INI file)."),
                new ColumnDefinition("Key", ColumnType.String, 128, primaryKey: false, nullable: false, ColumnCategory.Text, description: "Key value (followed by an equals sign in INI file)."),
                new ColumnDefinition("Field", ColumnType.Number, 2, primaryKey: false, nullable: true, ColumnCategory.Unknown, minValue: 0, maxValue: 32767, description: "The field in the .INI line. If Field is null or 0 the entire line is read."),
                new ColumnDefinition("Type", ColumnType.Number, 2, primaryKey: false, nullable: true, ColumnCategory.Unknown, minValue: 0, maxValue: 2, description: "An integer value that determines if the .INI value read is a filename or a directory location or to be used as is w/o interpretation."),
            },
            tupleDefinitionName: TupleDefinitions.IniLocator.Name,
            tupleIdIsPrimaryKey: false
        );

        public static readonly TableDefinition InstallExecuteSequence = new TableDefinition(
            "InstallExecuteSequence",
            new[]
            {
                new ColumnDefinition("Action", ColumnType.String, 72, primaryKey: true, nullable: false, ColumnCategory.Identifier, description: "Name of action to invoke, either in the engine or the handler DLL."),
                new ColumnDefinition("Condition", ColumnType.String, 255, primaryKey: false, nullable: true, ColumnCategory.Condition, description: "Optional expression which skips the action if evaluates to expFalse.If the expression syntax is invalid, the engine will terminate, returning iesBadActionData.", forceLocalizable: true),
                new ColumnDefinition("Sequence", ColumnType.Number, 2, primaryKey: false, nullable: true, ColumnCategory.Unknown, minValue: -4, maxValue: 32767, description: "Number that determines the sort order in which the actions are to be executed.  Leave blank to suppress action."),
            },
            tupleIdIsPrimaryKey: true
        );

        public static readonly TableDefinition InstallUISequence = new TableDefinition(
            "InstallUISequence",
            new[]
            {
                new ColumnDefinition("Action", ColumnType.String, 72, primaryKey: true, nullable: false, ColumnCategory.Identifier, description: "Name of action to invoke, either in the engine or the handler DLL."),
                new ColumnDefinition("Condition", ColumnType.String, 255, primaryKey: false, nullable: true, ColumnCategory.Condition, description: "Optional expression which skips the action if evaluates to expFalse.If the expression syntax is invalid, the engine will terminate, returning iesBadActionData.", forceLocalizable: true),
                new ColumnDefinition("Sequence", ColumnType.Number, 2, primaryKey: false, nullable: true, ColumnCategory.Unknown, minValue: -4, maxValue: 32767, description: "Number that determines the sort order in which the actions are to be executed.  Leave blank to suppress action."),
            },
            tupleIdIsPrimaryKey: true
        );

        public static readonly TableDefinition IsolatedComponent = new TableDefinition(
            "IsolatedComponent",
            new[]
            {
                new ColumnDefinition("Component_Shared", ColumnType.String, 72, primaryKey: true, nullable: false, ColumnCategory.Identifier, keyTable: "Component", keyColumn: 1, description: "Key to Component table item to be isolated", modularizeType: ColumnModularizeType.Column),
                new ColumnDefinition("Component_Application", ColumnType.String, 72, primaryKey: true, nullable: false, ColumnCategory.Identifier, keyTable: "Component", keyColumn: 1, description: "Key to Component table item for application", modularizeType: ColumnModularizeType.Column),
            },
            tupleDefinitionName: TupleDefinitions.IsolatedComponent.Name,
            tupleIdIsPrimaryKey: false
        );

        public static readonly TableDefinition LaunchCondition = new TableDefinition(
            "LaunchCondition",
            new[]
            {
                new ColumnDefinition("Condition", ColumnType.String, 255, primaryKey: true, nullable: false, ColumnCategory.Condition, description: "Expression which must evaluate to TRUE in order for install to commence.", forceLocalizable: true),
                new ColumnDefinition("Description", ColumnType.Localized, 255, primaryKey: false, nullable: false, ColumnCategory.Formatted, description: "Localizable text to display when condition fails and install must abort."),
            },
            tupleDefinitionName: TupleDefinitions.LaunchCondition.Name,
            tupleIdIsPrimaryKey: false
        );

        public static readonly TableDefinition ListBox = new TableDefinition(
            "ListBox",
            new[]
            {
                new ColumnDefinition("Property", ColumnType.String, 72, primaryKey: true, nullable: false, ColumnCategory.Identifier, description: "A named property to be tied to this item. All the items tied to the same property become part of the same listbox.", modularizeType: ColumnModularizeType.Column),
                new ColumnDefinition("Order", ColumnType.Number, 2, primaryKey: true, nullable: false, ColumnCategory.Unknown, minValue: 1, maxValue: 32767, description: "A positive integer used to determine the ordering of the items within one list..The integers do not have to be consecutive."),
                new ColumnDefinition("Value", ColumnType.String, 64, primaryKey: false, nullable: false, ColumnCategory.Formatted, description: "The value string associated with this item. Selecting the line will set the associated property to this value.", modularizeType: ColumnModularizeType.Property),
                new ColumnDefinition("Text", ColumnType.Localized, 64, primaryKey: false, nullable: true, ColumnCategory.Text, description: "The visible text to be assigned to the item. Optional. If this entry or the entire column is missing, the text is the same as the value."),
            },
            tupleDefinitionName: TupleDefinitions.ListBox.Name,
            tupleIdIsPrimaryKey: false
        );

        public static readonly TableDefinition ListView = new TableDefinition(
            "ListView",
            new[]
            {
                new ColumnDefinition("Property", ColumnType.String, 72, primaryKey: true, nullable: false, ColumnCategory.Identifier, description: "A named property to be tied to this item. All the items tied to the same property become part of the same listview.", modularizeType: ColumnModularizeType.Column),
                new ColumnDefinition("Order", ColumnType.Number, 2, primaryKey: true, nullable: false, ColumnCategory.Unknown, minValue: 1, maxValue: 32767, description: "A positive integer used to determine the ordering of the items within one list..The integers do not have to be consecutive."),
                new ColumnDefinition("Value", ColumnType.String, 64, primaryKey: false, nullable: false, ColumnCategory.Formatted, description: "The value string associated with this item. Selecting the line will set the associated property to this value.", modularizeType: ColumnModularizeType.Property),
                new ColumnDefinition("Text", ColumnType.Localized, 64, primaryKey: false, nullable: true, ColumnCategory.Formatted, description: "The visible text to be assigned to the item. Optional. If this entry or the entire column is missing, the text is the same as the value.", modularizeType: ColumnModularizeType.Property),
                new ColumnDefinition("Binary_", ColumnType.String, 72, primaryKey: false, nullable: true, ColumnCategory.Identifier, keyTable: "Binary", keyColumn: 1, description: "The name of the icon to be displayed with the icon. The binary information is looked up from the Binary Table.", modularizeType: ColumnModularizeType.Column),
            },
            tupleDefinitionName: TupleDefinitions.ListView.Name,
            tupleIdIsPrimaryKey: false
        );

        public static readonly TableDefinition LockPermissions = new TableDefinition(
            "LockPermissions",
            new[]
            {
                new ColumnDefinition("LockObject", ColumnType.String, 72, primaryKey: true, nullable: false, ColumnCategory.Identifier, description: "Foreign key into Registry or File table", modularizeType: ColumnModularizeType.Column),
                new ColumnDefinition("Table", ColumnType.String, 32, primaryKey: true, nullable: false, ColumnCategory.Identifier, possibilities: "Directory;File;Registry", description: "Reference to another table name"),
                new ColumnDefinition("Domain", ColumnType.String, 255, primaryKey: true, nullable: true, ColumnCategory.Formatted, description: "Domain name for user whose permissions are being set. (usually a property)", modularizeType: ColumnModularizeType.Property),
                new ColumnDefinition("User", ColumnType.String, 255, primaryKey: true, nullable: false, ColumnCategory.Formatted, description: "User for permissions to be set.  (usually a property)", modularizeType: ColumnModularizeType.Property),
                new ColumnDefinition("Permission", ColumnType.Number, 4, primaryKey: false, nullable: true, ColumnCategory.Unknown, minValue: -2147483647, maxValue: 2147483647, description: "Permission Access mask.  Full Control = 268435456 (GENERIC_ALL = 0x10000000)"),
            },
            tupleDefinitionName: TupleDefinitions.LockPermissions.Name,
            tupleIdIsPrimaryKey: false
        );

        public static readonly TableDefinition MsiLockPermissionsEx = new TableDefinition(
            "MsiLockPermissionsEx",
            new[]
            {
                new ColumnDefinition("MsiLockPermissionsEx", ColumnType.String, 72, primaryKey: true, nullable: false, ColumnCategory.Identifier, description: "Primary key, non-localized token", modularizeType: ColumnModularizeType.Column),
                new ColumnDefinition("LockObject", ColumnType.String, 72, primaryKey: false, nullable: false, ColumnCategory.Identifier, description: "Foreign key into Registry, File, CreateFolder, or ServiceInstall table", modularizeType: ColumnModularizeType.Column),
                new ColumnDefinition("Table", ColumnType.String, 32, primaryKey: false, nullable: false, ColumnCategory.Identifier, possibilities: "CreateFolder;File;Registry;ServiceInstall", description: "Reference to another table name"),
                new ColumnDefinition("SDDLText", ColumnType.String, 0, primaryKey: false, nullable: false, ColumnCategory.FormattedSDDLText, description: "String to indicate permissions to be applied to the LockObject", modularizeType: ColumnModularizeType.Property),
                new ColumnDefinition("Condition", ColumnType.String, 255, primaryKey: false, nullable: true, ColumnCategory.Formatted, description: "Expression which must evaluate to TRUE in order for this set of permissions to be applied", modularizeType: ColumnModularizeType.Property),
            },
            tupleDefinitionName: TupleDefinitions.MsiLockPermissionsEx.Name,
            tupleIdIsPrimaryKey: true
        );

        public static readonly TableDefinition Media = new TableDefinition(
            "Media",
            new[]
            {
                new ColumnDefinition("DiskId", ColumnType.Number, 2, primaryKey: true, nullable: false, ColumnCategory.Unknown, minValue: 1, maxValue: 32767, description: "Primary key, integer to determine sort order for table."),
                new ColumnDefinition("LastSequence", ColumnType.Number, 4, primaryKey: false, nullable: false, ColumnCategory.Unknown, minValue: 0, maxValue: 2147483647, description: "File sequence number for the last file for this media."),
                new ColumnDefinition("DiskPrompt", ColumnType.Localized, 64, primaryKey: false, nullable: true, ColumnCategory.Text, description: "Disk name: the visible text actually printed on the disk.  This will be used to prompt the user when this disk needs to be inserted."),
                new ColumnDefinition("Cabinet", ColumnType.String, 255, primaryKey: false, nullable: true, ColumnCategory.Cabinet, description: "If some or all of the files stored on the media are compressed in a cabinet, the name of that cabinet."),
                new ColumnDefinition("VolumeLabel", ColumnType.String, 32, primaryKey: false, nullable: true, ColumnCategory.Text, description: "The label attributed to the volume."),
                new ColumnDefinition("Source", ColumnType.String, 72, primaryKey: false, nullable: true, ColumnCategory.Property, description: "The property defining the location of the cabinet file."),
            },
            tupleDefinitionName: TupleDefinitions.Media.Name,
            tupleIdIsPrimaryKey: false
        );

        public static readonly TableDefinition MoveFile = new TableDefinition(
            "MoveFile",
            new[]
            {
                new ColumnDefinition("FileKey", ColumnType.String, 72, primaryKey: true, nullable: false, ColumnCategory.Identifier, description: "Primary key that uniquely identifies a particular MoveFile record", modularizeType: ColumnModularizeType.Column),
                new ColumnDefinition("Component_", ColumnType.String, 72, primaryKey: false, nullable: false, ColumnCategory.Identifier, keyTable: "Component", keyColumn: 1, description: "If this component is not \"selected\" for installation or removal, no action will be taken on the associated MoveFile entry", modularizeType: ColumnModularizeType.Column),
                new ColumnDefinition("SourceName", ColumnType.Localized, 255, primaryKey: false, nullable: true, ColumnCategory.Text, description: "Name of the source file(s) to be moved or copied.  Can contain the '*' or '?' wildcards."),
                new ColumnDefinition("DestName", ColumnType.Localized, 255, primaryKey: false, nullable: true, ColumnCategory.Filename, description: "Name to be given to the original file after it is moved or copied.  If blank, the destination file will be given the same name as the source file"),
                new ColumnDefinition("SourceFolder", ColumnType.String, 72, primaryKey: false, nullable: true, ColumnCategory.Identifier, description: "Name of a property whose value is assumed to resolve to the full path to the source directory", modularizeType: ColumnModularizeType.Column),
                new ColumnDefinition("DestFolder", ColumnType.String, 72, primaryKey: false, nullable: false, ColumnCategory.Identifier, description: "Name of a property whose value is assumed to resolve to the full path to the destination directory", modularizeType: ColumnModularizeType.Column),
                new ColumnDefinition("Options", ColumnType.Number, 2, primaryKey: false, nullable: false, ColumnCategory.Unknown, minValue: 0, maxValue: 1, description: "Integer value specifying the MoveFile operating mode, one of imfoEnum"),
            },
            tupleDefinitionName: TupleDefinitions.MoveFile.Name,
            tupleIdIsPrimaryKey: true
        );

        public static readonly TableDefinition MsiAssembly = new TableDefinition(
            "MsiAssembly",
            new[]
            {
                new ColumnDefinition("Component_", ColumnType.String, 72, primaryKey: true, nullable: false, ColumnCategory.Identifier, keyTable: "Component", keyColumn: 1, description: "Foreign key into Component table.", modularizeType: ColumnModularizeType.Column),
                new ColumnDefinition("Feature_", ColumnType.String, 38, primaryKey: false, nullable: false, ColumnCategory.Identifier, keyTable: "Feature", keyColumn: 1, description: "Foreign key into Feature table."),
                new ColumnDefinition("File_Manifest", ColumnType.String, 72, primaryKey: false, nullable: true, ColumnCategory.Identifier, keyTable: "File", keyColumn: 1, description: "Foreign key into the File table denoting the manifest file for the assembly.", modularizeType: ColumnModularizeType.Column),
                new ColumnDefinition("File_Application", ColumnType.String, 72, primaryKey: false, nullable: true, ColumnCategory.Identifier, keyTable: "File", keyColumn: 1, description: "Foreign key into File table, denoting the application context for private assemblies. Null for global assemblies.", modularizeType: ColumnModularizeType.Column),
                new ColumnDefinition("Attributes", ColumnType.Number, 2, primaryKey: false, nullable: true, ColumnCategory.Unknown, description: "Assembly attributes"),
            },
            tupleDefinitionName: TupleDefinitions.Assembly.Name,
            tupleIdIsPrimaryKey: false
        );

        public static readonly TableDefinition MsiAssemblyName = new TableDefinition(
            "MsiAssemblyName",
            new[]
            {
                new ColumnDefinition("Component_", ColumnType.String, 72, primaryKey: true, nullable: false, ColumnCategory.Identifier, keyTable: "Component", keyColumn: 1, description: "Foreign key into Component table.", modularizeType: ColumnModularizeType.Column),
                new ColumnDefinition("Name", ColumnType.String, 255, primaryKey: true, nullable: false, ColumnCategory.Text, description: "The name part of the name-value pairs for the assembly name."),
                new ColumnDefinition("Value", ColumnType.String, 255, primaryKey: false, nullable: false, ColumnCategory.Text, description: "The value part of the name-value pairs for the assembly name."),
            },
            tupleDefinitionName: TupleDefinitions.MsiAssemblyName.Name,
            tupleIdIsPrimaryKey: false
        );

        public static readonly TableDefinition MsiDigitalCertificate = new TableDefinition(
            "MsiDigitalCertificate",
            new[]
            {
                new ColumnDefinition("DigitalCertificate", ColumnType.String, 72, primaryKey: true, nullable: false, ColumnCategory.Identifier, description: "A unique identifier for the row"),
                new ColumnDefinition("CertData", ColumnType.Object, 0, primaryKey: false, nullable: false, ColumnCategory.Binary, description: "A certificate context blob for a signer certificate"),
            },
            tupleDefinitionName: TupleDefinitions.MsiDigitalCertificate.Name,
            tupleIdIsPrimaryKey: true
        );

        public static readonly TableDefinition MsiDigitalSignature = new TableDefinition(
            "MsiDigitalSignature",
            new[]
            {
                new ColumnDefinition("Table", ColumnType.String, 32, primaryKey: true, nullable: false, ColumnCategory.Unknown, possibilities: "Media", description: "Reference to another table name (only Media table is supported)"),
                new ColumnDefinition("SignObject", ColumnType.String, 72, primaryKey: true, nullable: false, ColumnCategory.Text, description: "Foreign key to Media table"),
                new ColumnDefinition("DigitalCertificate_", ColumnType.String, 72, primaryKey: false, nullable: false, ColumnCategory.Identifier, keyTable: "MsiDigitalCertificate", keyColumn: 1, description: "Foreign key to MsiDigitalCertificate table identifying the signer certificate"),
                new ColumnDefinition("Hash", ColumnType.Object, 0, primaryKey: false, nullable: true, ColumnCategory.Binary, description: "The encoded hash blob from the digital signature"),
            },
            tupleDefinitionName: TupleDefinitions.MsiDigitalSignature.Name,
            tupleIdIsPrimaryKey: false
        );

        public static readonly TableDefinition MsiEmbeddedChainer = new TableDefinition(
            "MsiEmbeddedChainer",
            new[]
            {
                new ColumnDefinition("MsiEmbeddedChainer", ColumnType.String, 72, primaryKey: true, nullable: false, ColumnCategory.Identifier, description: "The primary key for the table.", modularizeType: ColumnModularizeType.Column),
                new ColumnDefinition("Condition", ColumnType.String, 255, primaryKey: false, nullable: true, ColumnCategory.Condition, description: "A conditional statement for running the user-defined function.", forceLocalizable: true),
                new ColumnDefinition("CommandLine", ColumnType.String, 255, primaryKey: false, nullable: true, ColumnCategory.Formatted, description: "The value in this field is a part of the command line string passed to the executable file identified in the Source column.", modularizeType: ColumnModularizeType.Property),
                new ColumnDefinition("Source", ColumnType.String, 72, primaryKey: false, nullable: false, ColumnCategory.CustomSource, description: "The location of the executable file for the user-defined function.", modularizeType: ColumnModularizeType.Column),
                new ColumnDefinition("Type", ColumnType.Number, 2, primaryKey: false, nullable: false, ColumnCategory.Unknown, possibilities: "2;18;50", description: "The functions listed in the MsiEmbeddedChainer table are described using the following custom action numeric types."),
            },
            tupleDefinitionName: TupleDefinitions.MsiEmbeddedChainer.Name,
            tupleIdIsPrimaryKey: true
        );

        public static readonly TableDefinition MsiEmbeddedUI = new TableDefinition(
            "MsiEmbeddedUI",
            new[]
            {
                new ColumnDefinition("MsiEmbeddedUI", ColumnType.String, 72, primaryKey: true, nullable: false, ColumnCategory.Identifier, description: "The primary key for the table.", modularizeType: ColumnModularizeType.Column),
                new ColumnDefinition("FileName", ColumnType.Localized, 255, primaryKey: false, nullable: false, ColumnCategory.Text, description: "The name of the file that receives the binary information in the Data column."),
                new ColumnDefinition("Attributes", ColumnType.Number, 2, primaryKey: false, nullable: false, ColumnCategory.Unknown, possibilities: "0;1;2;3", description: "Information about the data in the Data column."),
                new ColumnDefinition("MessageFilter", ColumnType.Number, 4, primaryKey: false, nullable: true, ColumnCategory.Unknown, description: "Specifies the types of messages that are sent to the user interface DLL."),
                new ColumnDefinition("Data", ColumnType.Object, 0, primaryKey: false, nullable: false, ColumnCategory.Binary, description: "This column contains binary information."),
            },
            tupleDefinitionName: TupleDefinitions.MsiEmbeddedUI.Name,
            tupleIdIsPrimaryKey: true
        );

        public static readonly TableDefinition MsiFileHash = new TableDefinition(
            "MsiFileHash",
            new[]
            {
                new ColumnDefinition("File_", ColumnType.String, 72, primaryKey: true, nullable: false, ColumnCategory.Identifier, keyTable: "File", keyColumn: 1, description: "Primary key, foreign key into File table referencing file with this hash", modularizeType: ColumnModularizeType.Column),
                new ColumnDefinition("Options", ColumnType.Number, 2, primaryKey: false, nullable: false, ColumnCategory.Unknown, minValue: 0, maxValue: 32767, description: "Various options and attributes for this hash."),
                new ColumnDefinition("HashPart1", ColumnType.Number, 4, primaryKey: false, nullable: false, ColumnCategory.Unknown, description: "Size of file in bytes (long integer)."),
                new ColumnDefinition("HashPart2", ColumnType.Number, 4, primaryKey: false, nullable: false, ColumnCategory.Unknown, description: "Size of file in bytes (long integer)."),
                new ColumnDefinition("HashPart3", ColumnType.Number, 4, primaryKey: false, nullable: false, ColumnCategory.Unknown, description: "Size of file in bytes (long integer)."),
                new ColumnDefinition("HashPart4", ColumnType.Number, 4, primaryKey: false, nullable: false, ColumnCategory.Unknown, description: "Size of file in bytes (long integer)."),
            },
            tupleDefinitionName: TupleDefinitions.MsiFileHash.Name,
            tupleIdIsPrimaryKey: true
        );

        public static readonly TableDefinition MsiPackageCertificate = new TableDefinition(
            "MsiPackageCertificate",
            new[]
            {
                new ColumnDefinition("PackageCertificate", ColumnType.String, 72, primaryKey: true, nullable: false, ColumnCategory.Identifier, description: "Primary key. A unique identifier for the row."),
                new ColumnDefinition("DigitalCertificate_", ColumnType.String, 72, primaryKey: true, nullable: false, ColumnCategory.Identifier, keyTable: "MsiDigitalCertificate", keyColumn: 1, description: "Foreign key to MsiDigitalCertificate table identifying the signer certificate."),
            },
            tupleDefinitionName: TupleDefinitions.MsiPackageCertificate.Name,
            tupleIdIsPrimaryKey: false
        );

        public static readonly TableDefinition MsiPatchCertificate = new TableDefinition(
            "MsiPatchCertificate",
            new[]
            {
                new ColumnDefinition("PatchCertificate", ColumnType.String, 72, primaryKey: true, nullable: false, ColumnCategory.Identifier, description: "Primary key. A unique identifier for the row."),
                new ColumnDefinition("DigitalCertificate_", ColumnType.String, 72, primaryKey: true, nullable: false, ColumnCategory.Identifier, keyTable: "MsiDigitalCertificate", keyColumn: 1, description: "Foreign key to MsiDigitalCertificate table identifying the signer certificate."),
            },
            tupleDefinitionName: TupleDefinitions.MsiPatchCertificate.Name,
            tupleIdIsPrimaryKey: false
        );

        public static readonly TableDefinition MsiPatchHeaders = new TableDefinition(
            "MsiPatchHeaders",
            new[]
            {
                new ColumnDefinition("StreamRef", ColumnType.String, 38, primaryKey: true, nullable: false, ColumnCategory.Identifier, description: "Primary key. A unique identifier for the row."),
                new ColumnDefinition("Header", ColumnType.Object, 0, primaryKey: false, nullable: false, ColumnCategory.Binary, description: "Binary stream. The patch header, used for patch validation."),
            },
            tupleDefinitionName: TupleDefinitions.MsiPatchHeaders.Name,
            tupleIdIsPrimaryKey: false
        );

        public static readonly TableDefinition PatchMetadata = new TableDefinition(
            "PatchMetadata",
            new[]
            {
                new ColumnDefinition("Company", ColumnType.String, 72, primaryKey: true, nullable: true, ColumnCategory.Identifier, description: "Primary key. The name of the company."),
                new ColumnDefinition("Property", ColumnType.String, 72, primaryKey: true, nullable: false, ColumnCategory.Identifier, description: "Primary key. The name of the property."),
                new ColumnDefinition("Value", ColumnType.Localized, 0, primaryKey: false, nullable: false, ColumnCategory.Text, description: "Non-null, non-empty value of the metadata property."),
            },
            tupleDefinitionName: TupleDefinitions.PatchMetadata.Name,
            tupleIdIsPrimaryKey: false
        );

        public static readonly TableDefinition MsiPatchMetadata = new TableDefinition(
            "MsiPatchMetadata",
            new[]
            {
                new ColumnDefinition("Company", ColumnType.String, 72, primaryKey: true, nullable: true, ColumnCategory.Unknown),
                new ColumnDefinition("Property", ColumnType.String, 72, primaryKey: true, nullable: false, ColumnCategory.Unknown),
                new ColumnDefinition("Value", ColumnType.Localized, 0, primaryKey: false, nullable: false, ColumnCategory.Unknown),
            },
            tupleDefinitionName: TupleDefinitions.MsiPatchMetadata.Name,
            tupleIdIsPrimaryKey: false
        );

        public static readonly TableDefinition MsiPatchOldAssemblyFile = new TableDefinition(
            "MsiPatchOldAssemblyFile",
            new[]
            {
                new ColumnDefinition("File_", ColumnType.String, 72, primaryKey: true, nullable: false, ColumnCategory.Identifier, keyTable: "File", keyColumn: 1, description: "Foreign key into File table. Patch-only table.", modularizeType: ColumnModularizeType.Column),
                new ColumnDefinition("Assembly_", ColumnType.String, 72, primaryKey: true, nullable: false, ColumnCategory.Identifier, keyTable: "MsiPatchOldAssemblyName", keyColumn: 1, description: "Foreign key into MsiPatchOldAssemblyName table.", modularizeType: ColumnModularizeType.Column),
            },
            tupleDefinitionName: TupleDefinitions.MsiPatchOldAssemblyFile.Name,
            tupleIdIsPrimaryKey: false
        );

        public static readonly TableDefinition MsiPatchOldAssemblyName = new TableDefinition(
            "MsiPatchOldAssemblyName",
            new[]
            {
                new ColumnDefinition("Assembly", ColumnType.String, 72, primaryKey: true, nullable: false, ColumnCategory.Identifier, description: "A unique identifier for the row.", modularizeType: ColumnModularizeType.Column),
                new ColumnDefinition("Name", ColumnType.String, 255, primaryKey: true, nullable: false, ColumnCategory.Text, description: "The name part of the name-value pairs for the assembly name. This represents the old name for the assembly."),
                new ColumnDefinition("Value", ColumnType.String, 255, primaryKey: false, nullable: false, ColumnCategory.Text, description: "The value part of the name-value pairs for the assembly name. This represents the old name for the assembly."),
            },
            tupleDefinitionName: TupleDefinitions.MsiPatchOldAssemblyName.Name,
            tupleIdIsPrimaryKey: false
        );

        public static readonly TableDefinition PatchSequence = new TableDefinition(
            "PatchSequence",
            new[]
            {
                new ColumnDefinition("PatchFamily", ColumnType.String, 72, primaryKey: true, nullable: false, ColumnCategory.Identifier, description: "Primary key. The name of the family for the patch."),
                new ColumnDefinition("Target", ColumnType.String, 72, primaryKey: true, nullable: true, ColumnCategory.Text, description: "Primary key. Determines product code filtering for family."),
                new ColumnDefinition("Sequence", ColumnType.String, 72, primaryKey: false, nullable: true, ColumnCategory.Text, description: "Sequence information in version (x.x.x.x) format."),
                new ColumnDefinition("Supersede", ColumnType.Number, 4, primaryKey: false, nullable: true, ColumnCategory.Unknown, description: "Indicates that this patch supersedes earlier patches."),
            },
            tupleDefinitionName: TupleDefinitions.PatchSequence.Name,
            tupleIdIsPrimaryKey: false
        );

        public static readonly TableDefinition MsiPatchSequence = new TableDefinition(
            "MsiPatchSequence",
            new[]
            {
                new ColumnDefinition("PatchFamily", ColumnType.String, 72, primaryKey: true, nullable: false, ColumnCategory.Unknown),
                new ColumnDefinition("ProductCode", ColumnType.String, 38, primaryKey: true, nullable: true, ColumnCategory.Unknown),
                new ColumnDefinition("Sequence", ColumnType.String, 72, primaryKey: false, nullable: false, ColumnCategory.Unknown),
                new ColumnDefinition("Attributes", ColumnType.Number, 4, primaryKey: false, nullable: true, ColumnCategory.Unknown),
            },
            tupleDefinitionName: TupleDefinitions.MsiPatchSequence.Name,
            tupleIdIsPrimaryKey: false
        );

        public static readonly TableDefinition ODBCAttribute = new TableDefinition(
            "ODBCAttribute",
            new[]
            {
                new ColumnDefinition("Driver_", ColumnType.String, 72, primaryKey: true, nullable: false, ColumnCategory.Identifier, keyTable: "ODBCDriver", keyColumn: 1, description: "Reference to ODBC driver in ODBCDriver table", modularizeType: ColumnModularizeType.Column),
                new ColumnDefinition("Attribute", ColumnType.String, 40, primaryKey: true, nullable: false, ColumnCategory.Text, description: "Name of ODBC driver attribute"),
                new ColumnDefinition("Value", ColumnType.Localized, 255, primaryKey: false, nullable: true, ColumnCategory.Formatted, description: "Value for ODBC driver attribute"),
            },
            tupleDefinitionName: TupleDefinitions.ODBCAttribute.Name,
            tupleIdIsPrimaryKey: false
        );

        public static readonly TableDefinition ODBCDriver = new TableDefinition(
            "ODBCDriver",
            new[]
            {
                new ColumnDefinition("Driver", ColumnType.String, 72, primaryKey: true, nullable: false, ColumnCategory.Identifier, description: "Primary key, non-localized.internal token for driver", modularizeType: ColumnModularizeType.Column),
                new ColumnDefinition("Component_", ColumnType.String, 72, primaryKey: false, nullable: false, ColumnCategory.Identifier, keyTable: "Component", keyColumn: 1, description: "Reference to associated component", modularizeType: ColumnModularizeType.Column),
                new ColumnDefinition("Description", ColumnType.String, 255, primaryKey: false, nullable: false, ColumnCategory.Text, description: "Text used as registered name for driver, non-localized"),
                new ColumnDefinition("File_", ColumnType.String, 72, primaryKey: false, nullable: false, ColumnCategory.Identifier, keyTable: "File", keyColumn: 1, description: "Reference to key driver file", modularizeType: ColumnModularizeType.Column),
                new ColumnDefinition("File_Setup", ColumnType.String, 72, primaryKey: false, nullable: true, ColumnCategory.Identifier, keyTable: "File", keyColumn: 1, description: "Optional reference to key driver setup DLL", modularizeType: ColumnModularizeType.Column),
            },
            tupleDefinitionName: TupleDefinitions.ODBCDriver.Name,
            tupleIdIsPrimaryKey: true
        );

        public static readonly TableDefinition ODBCDataSource = new TableDefinition(
            "ODBCDataSource",
            new[]
            {
                new ColumnDefinition("DataSource", ColumnType.String, 72, primaryKey: true, nullable: false, ColumnCategory.Identifier, description: "Primary key, non-localized.internal token for data source", modularizeType: ColumnModularizeType.Column),
                new ColumnDefinition("Component_", ColumnType.String, 72, primaryKey: false, nullable: false, ColumnCategory.Identifier, keyTable: "Component", keyColumn: 1, description: "Reference to associated component", modularizeType: ColumnModularizeType.Column),
                new ColumnDefinition("Description", ColumnType.String, 255, primaryKey: false, nullable: false, ColumnCategory.Text, description: "Text used as registered name for data source"),
                new ColumnDefinition("DriverDescription", ColumnType.String, 255, primaryKey: false, nullable: false, ColumnCategory.Text, description: "Reference to driver description, may be existing driver"),
                new ColumnDefinition("Registration", ColumnType.Number, 2, primaryKey: false, nullable: false, ColumnCategory.Unknown, minValue: 0, maxValue: 1, description: "Registration option: 0=machine, 1=user, others t.b.d."),
            },
            tupleDefinitionName: TupleDefinitions.ODBCDataSource.Name,
            tupleIdIsPrimaryKey: true
        );

        public static readonly TableDefinition ODBCSourceAttribute = new TableDefinition(
            "ODBCSourceAttribute",
            new[]
            {
                new ColumnDefinition("DataSource_", ColumnType.String, 72, primaryKey: true, nullable: false, ColumnCategory.Identifier, keyTable: "ODBCDataSource", keyColumn: 1, description: "Reference to ODBC data source in ODBCDataSource table", modularizeType: ColumnModularizeType.Column),
                new ColumnDefinition("Attribute", ColumnType.String, 32, primaryKey: true, nullable: false, ColumnCategory.Text, description: "Name of ODBC data source attribute"),
                new ColumnDefinition("Value", ColumnType.Localized, 255, primaryKey: false, nullable: true, ColumnCategory.Formatted, description: "Value for ODBC data source attribute"),
            },
            tupleDefinitionName: TupleDefinitions.ODBCSourceAttribute.Name,
            tupleIdIsPrimaryKey: false
        );

        public static readonly TableDefinition ODBCTranslator = new TableDefinition(
            "ODBCTranslator",
            new[]
            {
                new ColumnDefinition("Translator", ColumnType.String, 72, primaryKey: true, nullable: false, ColumnCategory.Identifier, description: "Primary key, non-localized.internal token for translator", modularizeType: ColumnModularizeType.Column),
                new ColumnDefinition("Component_", ColumnType.String, 72, primaryKey: false, nullable: false, ColumnCategory.Identifier, keyTable: "Component", keyColumn: 1, description: "Reference to associated component", modularizeType: ColumnModularizeType.Column),
                new ColumnDefinition("Description", ColumnType.String, 255, primaryKey: false, nullable: false, ColumnCategory.Text, description: "Text used as registered name for translator"),
                new ColumnDefinition("File_", ColumnType.String, 72, primaryKey: false, nullable: false, ColumnCategory.Identifier, keyTable: "File", keyColumn: 1, description: "Reference to key translator file", modularizeType: ColumnModularizeType.Column),
                new ColumnDefinition("File_Setup", ColumnType.String, 72, primaryKey: false, nullable: true, ColumnCategory.Identifier, keyTable: "File", keyColumn: 1, description: "Optional reference to key translator setup DLL", modularizeType: ColumnModularizeType.Column),
            },
            tupleDefinitionName: TupleDefinitions.ODBCTranslator.Name,
            tupleIdIsPrimaryKey: true
        );

        public static readonly TableDefinition Patch = new TableDefinition(
            "Patch",
            new[]
            {
                new ColumnDefinition("File_", ColumnType.String, 72, primaryKey: true, nullable: false, ColumnCategory.Identifier, description: "Primary key, non-localized token, foreign key to File table, must match identifier in cabinet.", modularizeType: ColumnModularizeType.Column),
                new ColumnDefinition("Sequence", ColumnType.Number, 4, primaryKey: true, nullable: false, ColumnCategory.Unknown, minValue: 0, maxValue: 2147483647, description: "Primary key, sequence with respect to the media images; order must track cabinet order."),
                new ColumnDefinition("PatchSize", ColumnType.Number, 4, primaryKey: false, nullable: false, ColumnCategory.Unknown, minValue: 0, maxValue: 2147483647, description: "Size of patch in bytes (long integer)."),
                new ColumnDefinition("Attributes", ColumnType.Number, 2, primaryKey: false, nullable: false, ColumnCategory.Unknown, minValue: 0, maxValue: 32767, description: "Integer containing bit flags representing patch attributes"),
                new ColumnDefinition("Header", ColumnType.Object, 0, primaryKey: false, nullable: true, ColumnCategory.Binary, description: "Binary stream. The patch header, used for patch validation."),
                new ColumnDefinition("StreamRef_", ColumnType.String, 38, primaryKey: false, nullable: true, ColumnCategory.Identifier, description: "Identifier. Foreign key to the StreamRef column of the MsiPatchHeaders table."),
            },
            tupleDefinitionName: TupleDefinitions.Patch.Name,
            tupleIdIsPrimaryKey: false
        );

        public static readonly TableDefinition PatchPackage = new TableDefinition(
            "PatchPackage",
            new[]
            {
                new ColumnDefinition("PatchId", ColumnType.String, 38, primaryKey: true, nullable: false, ColumnCategory.Guid, description: "A unique string GUID representing this patch."),
                new ColumnDefinition("Media_", ColumnType.Number, 2, primaryKey: false, nullable: false, ColumnCategory.Unknown, minValue: 0, maxValue: 32767, description: "Foreign key to DiskId column of Media table. Indicates the disk containing the patch package."),
            },
            tupleDefinitionName: TupleDefinitions.PatchPackage.Name,
            tupleIdIsPrimaryKey: false
        );

        public static readonly TableDefinition PublishComponent = new TableDefinition(
            "PublishComponent",
            new[]
            {
                new ColumnDefinition("ComponentId", ColumnType.String, 38, primaryKey: true, nullable: false, ColumnCategory.Guid, description: "A string GUID that represents the component id that will be requested by the alien product."),
                new ColumnDefinition("Qualifier", ColumnType.String, 255, primaryKey: true, nullable: false, ColumnCategory.Text, description: "This is defined only when the ComponentId column is an Qualified Component Id. This is the Qualifier for ProvideComponentIndirect."),
                new ColumnDefinition("Component_", ColumnType.String, 72, primaryKey: true, nullable: false, ColumnCategory.Identifier, keyTable: "Component", keyColumn: 1, description: "Foreign key into the Component table.", modularizeType: ColumnModularizeType.Column),
                new ColumnDefinition("AppData", ColumnType.Localized, 0, primaryKey: false, nullable: true, ColumnCategory.Text, description: "This is localisable Application specific data that can be associated with a Qualified Component."),
                new ColumnDefinition("Feature_", ColumnType.String, 38, primaryKey: false, nullable: false, ColumnCategory.Identifier, keyTable: "Feature", keyColumn: 1, description: "Foreign key into the Feature table."),
            },
            tupleDefinitionName: TupleDefinitions.PublishComponent.Name,
            tupleIdIsPrimaryKey: false
        );

        public static readonly TableDefinition RadioButton = new TableDefinition(
            "RadioButton",
            new[]
            {
                new ColumnDefinition("Property", ColumnType.String, 72, primaryKey: true, nullable: false, ColumnCategory.Identifier, description: "A named property to be tied to this radio button. All the buttons tied to the same property become part of the same group.", modularizeType: ColumnModularizeType.Column),
                new ColumnDefinition("Order", ColumnType.Number, 2, primaryKey: true, nullable: false, ColumnCategory.Unknown, minValue: 1, maxValue: 32767, description: "A positive integer used to determine the ordering of the items within one list..The integers do not have to be consecutive."),
                new ColumnDefinition("Value", ColumnType.String, 64, primaryKey: false, nullable: false, ColumnCategory.Formatted, description: "The value string associated with this button. Selecting the button will set the associated property to this value.", modularizeType: ColumnModularizeType.Property),
                new ColumnDefinition("X", ColumnType.Number, 2, primaryKey: false, nullable: false, ColumnCategory.Unknown, minValue: 0, maxValue: 32767, description: "The horizontal coordinate of the upper left corner of the bounding rectangle of the radio button.", forceLocalizable: true),
                new ColumnDefinition("Y", ColumnType.Number, 2, primaryKey: false, nullable: false, ColumnCategory.Unknown, minValue: 0, maxValue: 32767, description: "The vertical coordinate of the upper left corner of the bounding rectangle of the radio button.", forceLocalizable: true),
                new ColumnDefinition("Width", ColumnType.Number, 2, primaryKey: false, nullable: false, ColumnCategory.Unknown, minValue: 0, maxValue: 32767, description: "The width of the button.", forceLocalizable: true),
                new ColumnDefinition("Height", ColumnType.Number, 2, primaryKey: false, nullable: false, ColumnCategory.Unknown, minValue: 0, maxValue: 32767, description: "The height of the button.", forceLocalizable: true),
                new ColumnDefinition("Text", ColumnType.Localized, 0, primaryKey: false, nullable: true, ColumnCategory.Text, description: "The visible title to be assigned to the radio button."),
                new ColumnDefinition("Help", ColumnType.Localized, 50, primaryKey: false, nullable: true, ColumnCategory.Text, description: "The help strings used with the button. The text is optional."),
            },
            tupleDefinitionName: TupleDefinitions.RadioButton.Name,
            tupleIdIsPrimaryKey: false
        );

        public static readonly TableDefinition Registry = new TableDefinition(
            "Registry",
            new[]
            {
                new ColumnDefinition("Registry", ColumnType.String, 72, primaryKey: true, nullable: false, ColumnCategory.Identifier, description: "Primary key, non-localized token.", modularizeType: ColumnModularizeType.Column),
                new ColumnDefinition("Root", ColumnType.Number, 2, primaryKey: false, nullable: false, ColumnCategory.Unknown, minValue: -1, maxValue: 3, description: "The predefined root key for the registry value, one of rrkEnum."),
                new ColumnDefinition("Key", ColumnType.Localized, 255, primaryKey: false, nullable: false, ColumnCategory.RegPath, description: "The key for the registry value.", modularizeType: ColumnModularizeType.Property),
                new ColumnDefinition("Name", ColumnType.Localized, 255, primaryKey: false, nullable: true, ColumnCategory.Formatted, description: "The registry value name.", modularizeType: ColumnModularizeType.Property),
                new ColumnDefinition("Value", ColumnType.Localized, 0, primaryKey: false, nullable: true, ColumnCategory.Formatted, description: "The registry value.", modularizeType: ColumnModularizeType.Property),
                new ColumnDefinition("Component_", ColumnType.String, 72, primaryKey: false, nullable: false, ColumnCategory.Identifier, keyTable: "Component", keyColumn: 1, description: "Foreign key into the Component table referencing component that controls the installing of the registry value.", modularizeType: ColumnModularizeType.Column),
            },
            tupleDefinitionName: TupleDefinitions.Registry.Name,
            tupleIdIsPrimaryKey: true
        );

        public static readonly TableDefinition RegLocator = new TableDefinition(
            "RegLocator",
            new[]
            {
                new ColumnDefinition("Signature_", ColumnType.String, 72, primaryKey: true, nullable: false, ColumnCategory.Identifier, description: "The table key. The Signature_ represents a unique file signature and is also the foreign key in the Signature table. If the type is 0, the registry values refers a directory, and _Signature is not a foreign key.", modularizeType: ColumnModularizeType.Column),
                new ColumnDefinition("Root", ColumnType.Number, 2, primaryKey: false, nullable: false, ColumnCategory.Unknown, minValue: 0, maxValue: 3, description: "The predefined root key for the registry value, one of rrkEnum."),
                new ColumnDefinition("Key", ColumnType.String, 255, primaryKey: false, nullable: false, ColumnCategory.RegPath, description: "The key for the registry value.", modularizeType: ColumnModularizeType.Property, forceLocalizable: true),
                new ColumnDefinition("Name", ColumnType.String, 255, primaryKey: false, nullable: true, ColumnCategory.Formatted, description: "The registry value name.", modularizeType: ColumnModularizeType.Property, forceLocalizable: true),
                new ColumnDefinition("Type", ColumnType.Number, 2, primaryKey: false, nullable: true, ColumnCategory.Unknown, minValue: 0, maxValue: 18, description: "An integer value that determines if the registry value is a filename or a directory location or to be used as is w/o interpretation."),
            },
            tupleDefinitionName: TupleDefinitions.RegLocator.Name,
            tupleIdIsPrimaryKey: true
        );

        public static readonly TableDefinition RemoveFile = new TableDefinition(
            "RemoveFile",
            new[]
            {
                new ColumnDefinition("FileKey", ColumnType.String, 72, primaryKey: true, nullable: false, ColumnCategory.Identifier, description: "Primary key used to identify a particular file entry", modularizeType: ColumnModularizeType.Column),
                new ColumnDefinition("Component_", ColumnType.String, 72, primaryKey: false, nullable: false, ColumnCategory.Identifier, keyTable: "Component", keyColumn: 1, description: "Foreign key referencing Component that controls the file to be removed.", modularizeType: ColumnModularizeType.Column),
                new ColumnDefinition("FileName", ColumnType.Localized, 255, primaryKey: false, nullable: true, ColumnCategory.WildCardFilename, description: "Name of the file to be removed."),
                new ColumnDefinition("DirProperty", ColumnType.String, 72, primaryKey: false, nullable: false, ColumnCategory.Identifier, description: "Name of a property whose value is assumed to resolve to the full pathname to the folder of the file to be removed.", modularizeType: ColumnModularizeType.Column),
                new ColumnDefinition("InstallMode", ColumnType.Number, 2, primaryKey: false, nullable: false, ColumnCategory.Unknown, possibilities: "1;2;3", description: "Installation option, one of iimEnum."),
            },
            tupleDefinitionName: TupleDefinitions.RemoveFile.Name,
            tupleIdIsPrimaryKey: true
        );

        public static readonly TableDefinition RemoveIniFile = new TableDefinition(
            "RemoveIniFile",
            new[]
            {
                new ColumnDefinition("RemoveIniFile", ColumnType.String, 72, primaryKey: true, nullable: false, ColumnCategory.Identifier, description: "Primary key, non-localized token.", modularizeType: ColumnModularizeType.Column),
                new ColumnDefinition("FileName", ColumnType.Localized, 255, primaryKey: false, nullable: false, ColumnCategory.Filename, description: "The .INI file name in which to delete the information"),
                new ColumnDefinition("DirProperty", ColumnType.String, 72, primaryKey: false, nullable: true, ColumnCategory.Identifier, description: "Foreign key into the Directory table denoting the directory where the .INI file is.", modularizeType: ColumnModularizeType.Column),
                new ColumnDefinition("Section", ColumnType.Localized, 96, primaryKey: false, nullable: false, ColumnCategory.Formatted, description: "The .INI file Section.", modularizeType: ColumnModularizeType.Property),
                new ColumnDefinition("Key", ColumnType.Localized, 128, primaryKey: false, nullable: false, ColumnCategory.Formatted, description: "The .INI file key below Section.", modularizeType: ColumnModularizeType.Property),
                new ColumnDefinition("Value", ColumnType.Localized, 255, primaryKey: false, nullable: true, ColumnCategory.Formatted, description: "The value to be deleted. The value is required when Action is iifIniRemoveTag", modularizeType: ColumnModularizeType.Property),
                new ColumnDefinition("Action", ColumnType.Number, 2, primaryKey: false, nullable: false, ColumnCategory.Unknown, possibilities: "2;4", description: "The type of modification to be made, one of iifEnum."),
                new ColumnDefinition("Component_", ColumnType.String, 72, primaryKey: false, nullable: false, ColumnCategory.Identifier, keyTable: "Component", keyColumn: 1, description: "Foreign key into the Component table referencing component that controls the deletion of the .INI value.", modularizeType: ColumnModularizeType.Column),
            },
            tupleIdIsPrimaryKey: true
        );

        public static readonly TableDefinition RemoveRegistry = new TableDefinition(
            "RemoveRegistry",
            new[]
            {
                new ColumnDefinition("RemoveRegistry", ColumnType.String, 72, primaryKey: true, nullable: false, ColumnCategory.Identifier, description: "Primary key, non-localized token.", modularizeType: ColumnModularizeType.Column),
                new ColumnDefinition("Root", ColumnType.Number, 2, primaryKey: false, nullable: false, ColumnCategory.Unknown, minValue: -1, maxValue: 3, description: "The predefined root key for the registry value, one of rrkEnum"),
                new ColumnDefinition("Key", ColumnType.Localized, 255, primaryKey: false, nullable: false, ColumnCategory.RegPath, description: "The key for the registry value.", modularizeType: ColumnModularizeType.Property),
                new ColumnDefinition("Name", ColumnType.Localized, 255, primaryKey: false, nullable: true, ColumnCategory.Formatted, description: "The registry value name.", modularizeType: ColumnModularizeType.Property),
                new ColumnDefinition("Component_", ColumnType.String, 72, primaryKey: false, nullable: false, ColumnCategory.Identifier, keyTable: "Component", keyColumn: 1, description: "Foreign key into the Component table referencing component that controls the deletion of the registry value.", modularizeType: ColumnModularizeType.Column),
            },
            tupleDefinitionName: TupleDefinitions.RemoveRegistry.Name,
            tupleIdIsPrimaryKey: true
        );

        public static readonly TableDefinition ReserveCost = new TableDefinition(
            "ReserveCost",
            new[]
            {
                new ColumnDefinition("ReserveKey", ColumnType.String, 72, primaryKey: true, nullable: false, ColumnCategory.Identifier, description: "Primary key that uniquely identifies a particular ReserveCost record", modularizeType: ColumnModularizeType.Column),
                new ColumnDefinition("Component_", ColumnType.String, 72, primaryKey: false, nullable: false, ColumnCategory.Identifier, keyTable: "Component", keyColumn: 1, description: "Reserve a specified amount of space if this component is to be installed.", modularizeType: ColumnModularizeType.Column),
                new ColumnDefinition("ReserveFolder", ColumnType.String, 72, primaryKey: false, nullable: true, ColumnCategory.Identifier, description: "Name of a property whose value is assumed to resolve to the full path to the destination directory", modularizeType: ColumnModularizeType.Column),
                new ColumnDefinition("ReserveLocal", ColumnType.Number, 4, primaryKey: false, nullable: false, ColumnCategory.Unknown, minValue: 0, maxValue: 2147483647, description: "Disk space to reserve if linked component is installed locally."),
                new ColumnDefinition("ReserveSource", ColumnType.Number, 4, primaryKey: false, nullable: false, ColumnCategory.Unknown, minValue: 0, maxValue: 2147483647, description: "Disk space to reserve if linked component is installed to run from the source location."),
            },
            tupleDefinitionName: TupleDefinitions.ReserveCost.Name,
            tupleIdIsPrimaryKey: true
        );

        public static readonly TableDefinition SelfReg = new TableDefinition(
            "SelfReg",
            new[]
            {
                new ColumnDefinition("File_", ColumnType.String, 72, primaryKey: true, nullable: false, ColumnCategory.Identifier, keyTable: "File", keyColumn: 1, description: "Foreign key into the File table denoting the module that needs to be registered.", modularizeType: ColumnModularizeType.Column),
                new ColumnDefinition("Cost", ColumnType.Number, 2, primaryKey: false, nullable: true, ColumnCategory.Unknown, minValue: 0, maxValue: 32767, description: "The cost of registering the module."),
            },
            tupleIdIsPrimaryKey: false
        );

        public static readonly TableDefinition ServiceControl = new TableDefinition(
            "ServiceControl",
            new[]
            {
                new ColumnDefinition("ServiceControl", ColumnType.String, 72, primaryKey: true, nullable: false, ColumnCategory.Identifier, description: "Primary key, non-localized token.", modularizeType: ColumnModularizeType.Column),
                new ColumnDefinition("Name", ColumnType.Localized, 255, primaryKey: false, nullable: false, ColumnCategory.Formatted, description: "Name of a service. /, \\, comma and space are invalid", modularizeType: ColumnModularizeType.Property),
                new ColumnDefinition("Event", ColumnType.Number, 2, primaryKey: false, nullable: false, ColumnCategory.Unknown, minValue: 0, maxValue: 187, description: "Bit field:  Install:  0x1 = Start, 0x2 = Stop, 0x8 = Delete, Uninstall: 0x10 = Start, 0x20 = Stop, 0x80 = Delete"),
                new ColumnDefinition("Arguments", ColumnType.Localized, 255, primaryKey: false, nullable: true, ColumnCategory.Formatted, description: "Arguments for the service.  Separate by [~].", modularizeType: ColumnModularizeType.Property),
                new ColumnDefinition("Wait", ColumnType.Number, 2, primaryKey: false, nullable: true, ColumnCategory.Unknown, minValue: 0, maxValue: 1, description: "Boolean for whether to wait for the service to fully start"),
                new ColumnDefinition("Component_", ColumnType.String, 72, primaryKey: false, nullable: false, ColumnCategory.Identifier, keyTable: "Component", keyColumn: 1, description: "Required foreign key into the Component Table that controls the startup of the service", modularizeType: ColumnModularizeType.Column),
            },
            tupleDefinitionName: TupleDefinitions.ServiceControl.Name,
            tupleIdIsPrimaryKey: true
        );

        public static readonly TableDefinition ServiceInstall = new TableDefinition(
            "ServiceInstall",
            new[]
            {
                new ColumnDefinition("ServiceInstall", ColumnType.String, 72, primaryKey: true, nullable: false, ColumnCategory.Identifier, description: "Primary key, non-localized token.", modularizeType: ColumnModularizeType.Column),
                new ColumnDefinition("Name", ColumnType.String, 255, primaryKey: false, nullable: false, ColumnCategory.Formatted, description: "Internal Name of the Service", modularizeType: ColumnModularizeType.Property),
                new ColumnDefinition("DisplayName", ColumnType.Localized, 255, primaryKey: false, nullable: true, ColumnCategory.Formatted, description: "External Name of the Service", modularizeType: ColumnModularizeType.Property),
                new ColumnDefinition("ServiceType", ColumnType.Number, 4, primaryKey: false, nullable: false, ColumnCategory.Unknown, minValue: -2147483647, maxValue: 2147483647, description: "Type of the service"),
                new ColumnDefinition("StartType", ColumnType.Number, 4, primaryKey: false, nullable: false, ColumnCategory.Unknown, minValue: 0, maxValue: 4, description: "Type of the service"),
                new ColumnDefinition("ErrorControl", ColumnType.Number, 4, primaryKey: false, nullable: false, ColumnCategory.Unknown, minValue: -2147483647, maxValue: 2147483647, description: "Severity of error if service fails to start"),
                new ColumnDefinition("LoadOrderGroup", ColumnType.String, 255, primaryKey: false, nullable: true, ColumnCategory.Formatted, description: "LoadOrderGroup", modularizeType: ColumnModularizeType.Property),
                new ColumnDefinition("Dependencies", ColumnType.String, 255, primaryKey: false, nullable: true, ColumnCategory.Formatted, description: "Other services this depends on to start.  Separate by [~], and end with [~][~]", modularizeType: ColumnModularizeType.Property),
                new ColumnDefinition("StartName", ColumnType.String, 255, primaryKey: false, nullable: true, ColumnCategory.Formatted, description: "User or object name to run service as", modularizeType: ColumnModularizeType.Property),
                new ColumnDefinition("Password", ColumnType.String, 255, primaryKey: false, nullable: true, ColumnCategory.Formatted, description: "password to run service with.  (with StartName)", modularizeType: ColumnModularizeType.Property),
                new ColumnDefinition("Arguments", ColumnType.String, 255, primaryKey: false, nullable: true, ColumnCategory.Formatted, description: "Arguments to include in every start of the service, passed to WinMain", modularizeType: ColumnModularizeType.Property),
                new ColumnDefinition("Component_", ColumnType.String, 72, primaryKey: false, nullable: false, ColumnCategory.Identifier, keyTable: "Component", keyColumn: 1, description: "Required foreign key into the Component Table that controls the startup of the service", modularizeType: ColumnModularizeType.Column),
                new ColumnDefinition("Description", ColumnType.Localized, 255, primaryKey: false, nullable: true, ColumnCategory.Text, description: "Description of service.", modularizeType: ColumnModularizeType.Property),
            },
            tupleDefinitionName: TupleDefinitions.ServiceInstall.Name,
            tupleIdIsPrimaryKey: true
        );

        public static readonly TableDefinition MsiServiceConfig = new TableDefinition(
            "MsiServiceConfig",
            new[]
            {
                new ColumnDefinition("MsiServiceConfig", ColumnType.String, 72, primaryKey: true, nullable: false, ColumnCategory.Identifier, description: "Primary key, non-localized token.", modularizeType: ColumnModularizeType.Column),
                new ColumnDefinition("Name", ColumnType.Localized, 255, primaryKey: false, nullable: false, ColumnCategory.Formatted, description: "Name of a service. /, \\, comma and space are invalid", modularizeType: ColumnModularizeType.Property),
                new ColumnDefinition("Event", ColumnType.Number, 2, primaryKey: false, nullable: false, ColumnCategory.Unknown, minValue: 0, maxValue: 7, description: "Bit field:   0x1 = Install, 0x2 = Uninstall, 0x4 = Reinstall"),
                new ColumnDefinition("ConfigType", ColumnType.Number, 4, primaryKey: false, nullable: false, ColumnCategory.Unknown, minValue: -2147483647, maxValue: 2147483647, description: "Service Configuration Option"),
                new ColumnDefinition("Argument", ColumnType.String, 0, primaryKey: false, nullable: true, ColumnCategory.Text, description: "Argument(s) for service configuration. Value depends on the content of the ConfigType field"),
                new ColumnDefinition("Component_", ColumnType.String, 72, primaryKey: false, nullable: false, ColumnCategory.Identifier, keyTable: "Component", keyColumn: 1, description: "Required foreign key into the Component Table that controls the configuration of the service", modularizeType: ColumnModularizeType.Column),
            },
            tupleDefinitionName: TupleDefinitions.MsiServiceConfig.Name,
            tupleIdIsPrimaryKey: true
        );

        public static readonly TableDefinition MsiServiceConfigFailureActions = new TableDefinition(
            "MsiServiceConfigFailureActions",
            new[]
            {
                new ColumnDefinition("MsiServiceConfigFailureActions", ColumnType.String, 72, primaryKey: true, nullable: false, ColumnCategory.Identifier, description: "Primary key, non-localized token", modularizeType: ColumnModularizeType.Column),
                new ColumnDefinition("Name", ColumnType.Localized, 255, primaryKey: false, nullable: false, ColumnCategory.Formatted, description: "Name of a service. /, \\, comma and space are invalid", modularizeType: ColumnModularizeType.Property),
                new ColumnDefinition("Event", ColumnType.Number, 2, primaryKey: false, nullable: false, ColumnCategory.Unknown, minValue: 0, maxValue: 7, description: "Bit field:   0x1 = Install, 0x2 = Uninstall, 0x4 = Reinstall"),
                new ColumnDefinition("ResetPeriod", ColumnType.Number, 4, primaryKey: false, nullable: true, ColumnCategory.Unknown, minValue: 0, maxValue: 2147483647, description: "Time in seconds after which to reset the failure count to zero. Leave blank if it should never be reset"),
                new ColumnDefinition("RebootMessage", ColumnType.Localized, 255, primaryKey: false, nullable: true, ColumnCategory.Formatted, description: "Message to be broadcast to server users before rebooting"),
                new ColumnDefinition("Command", ColumnType.Localized, 255, primaryKey: false, nullable: true, ColumnCategory.Formatted, description: "Command line of the process to CreateProcess function to execute"),
                new ColumnDefinition("Actions", ColumnType.String, 0, primaryKey: false, nullable: true, ColumnCategory.Text, description: "A list of integer actions separated by [~] delimiters: 0 = SC_ACTION_NONE, 1 = SC_ACTION_RESTART, 2 = SC_ACTION_REBOOT, 3 = SC_ACTION_RUN_COMMAND. Terminate with [~][~]"),
                new ColumnDefinition("DelayActions", ColumnType.String, 0, primaryKey: false, nullable: true, ColumnCategory.Text, description: "A list of delays (time in milli-seconds), separated by [~] delmiters, to wait before taking the corresponding Action. Terminate with [~][~]"),
                new ColumnDefinition("Component_", ColumnType.String, 72, primaryKey: false, nullable: false, ColumnCategory.Identifier, keyTable: "Component", keyColumn: 1, description: "Required foreign key into the Component Table that controls the configuration of failure actions for the service", modularizeType: ColumnModularizeType.Column),
            },
            tupleDefinitionName: TupleDefinitions.MsiServiceConfigFailureActions.Name,
            tupleIdIsPrimaryKey: true
        );

        public static readonly TableDefinition Shortcut = new TableDefinition(
            "Shortcut",
            new[]
            {
                new ColumnDefinition("Shortcut", ColumnType.String, 72, primaryKey: true, nullable: false, ColumnCategory.Identifier, description: "Primary key, non-localized token.", modularizeType: ColumnModularizeType.Column),
                new ColumnDefinition("Directory_", ColumnType.String, 72, primaryKey: false, nullable: false, ColumnCategory.Identifier, keyTable: "Directory", keyColumn: 1, description: "Foreign key into the Directory table denoting the directory where the shortcut file is created.", modularizeType: ColumnModularizeType.Column),
                new ColumnDefinition("Name", ColumnType.Localized, 128, primaryKey: false, nullable: false, ColumnCategory.Filename, description: "The name of the shortcut to be created."),
                new ColumnDefinition("Component_", ColumnType.String, 72, primaryKey: false, nullable: false, ColumnCategory.Identifier, keyTable: "Component", keyColumn: 1, description: "Foreign key into the Component table denoting the component whose selection gates the the shortcut creation/deletion.", modularizeType: ColumnModularizeType.Column),
                new ColumnDefinition("Target", ColumnType.String, 72, primaryKey: false, nullable: false, ColumnCategory.Shortcut, description: "The shortcut target. This is usually a property that is expanded to a file or a folder that the shortcut points to.", modularizeType: ColumnModularizeType.Property),
                new ColumnDefinition("Arguments", ColumnType.String, 255, primaryKey: false, nullable: true, ColumnCategory.Formatted, description: "The command-line arguments for the shortcut.", modularizeType: ColumnModularizeType.Property),
                new ColumnDefinition("Description", ColumnType.Localized, 255, primaryKey: false, nullable: true, ColumnCategory.Text, description: "The description for the shortcut."),
                new ColumnDefinition("Hotkey", ColumnType.Number, 2, primaryKey: false, nullable: true, ColumnCategory.Unknown, minValue: 0, maxValue: 32767, description: "The hotkey for the shortcut. It has the virtual-key code for the key in the low-order byte, and the modifier flags in the high-order byte. "),
                new ColumnDefinition("Icon_", ColumnType.String, 72, primaryKey: false, nullable: true, ColumnCategory.Identifier, keyTable: "Icon", keyColumn: 1, description: "Foreign key into the File table denoting the external icon file for the shortcut.", modularizeType: ColumnModularizeType.Icon),
                new ColumnDefinition("IconIndex", ColumnType.Number, 2, primaryKey: false, nullable: true, ColumnCategory.Unknown, minValue: -32767, maxValue: 32767, description: "The icon index for the shortcut."),
                new ColumnDefinition("ShowCmd", ColumnType.Number, 2, primaryKey: false, nullable: true, ColumnCategory.Unknown, possibilities: "1;3;7", description: "The show command for the application window.The following values may be used."),
                new ColumnDefinition("WkDir", ColumnType.String, 72, primaryKey: false, nullable: true, ColumnCategory.Identifier, description: "Name of property defining location of working directory.", modularizeType: ColumnModularizeType.Column),
                new ColumnDefinition("DisplayResourceDLL", ColumnType.String, 255, primaryKey: false, nullable: true, ColumnCategory.Formatted, description: "The Formatted string providing the full path to the language neutral file containing the MUI Manifest.", modularizeType: ColumnModularizeType.Property),
                new ColumnDefinition("DisplayResourceId", ColumnType.Number, 2, primaryKey: false, nullable: true, ColumnCategory.Unknown, minValue: 0, maxValue: 32767, description: "The display name index for the shortcut. This must be a non-negative number."),
                new ColumnDefinition("DescriptionResourceDLL", ColumnType.String, 255, primaryKey: false, nullable: true, ColumnCategory.Formatted, description: "The Formatted string providing the full path to the language neutral file containing the MUI Manifest.", modularizeType: ColumnModularizeType.Property),
                new ColumnDefinition("DescriptionResourceId", ColumnType.Number, 2, primaryKey: false, nullable: true, ColumnCategory.Unknown, minValue: 0, maxValue: 32767, description: "The description name index for the shortcut. This must be a non-negative number."),
            },
            tupleDefinitionName: TupleDefinitions.Shortcut.Name,
            tupleIdIsPrimaryKey: true
        );

        public static readonly TableDefinition MsiShortcutProperty = new TableDefinition(
            "MsiShortcutProperty",
            new[]
            {
                new ColumnDefinition("MsiShortcutProperty", ColumnType.String, 72, primaryKey: true, nullable: false, ColumnCategory.Identifier, description: "Primary key, non-localized token", modularizeType: ColumnModularizeType.Column),
                new ColumnDefinition("Shortcut_", ColumnType.String, 72, primaryKey: false, nullable: false, ColumnCategory.Identifier, keyTable: "Shortcut", keyColumn: 1, description: "Foreign key into the Shortcut table", modularizeType: ColumnModularizeType.Column),
                new ColumnDefinition("PropertyKey", ColumnType.String, 0, primaryKey: false, nullable: false, ColumnCategory.Formatted, description: "Canonical string representation of the Property Key being set", modularizeType: ColumnModularizeType.Property),
                new ColumnDefinition("PropVariantValue", ColumnType.String, 0, primaryKey: false, nullable: false, ColumnCategory.Formatted, description: "String representation of the value in the property", modularizeType: ColumnModularizeType.Property),
            },
            tupleDefinitionName: TupleDefinitions.MsiShortcutProperty.Name,
            tupleIdIsPrimaryKey: true
        );

        public static readonly TableDefinition Signature = new TableDefinition(
            "Signature",
            new[]
            {
                new ColumnDefinition("Signature", ColumnType.String, 72, primaryKey: true, nullable: false, ColumnCategory.Identifier, description: "The table key. The Signature represents a unique file signature.", modularizeType: ColumnModularizeType.Column),
                new ColumnDefinition("FileName", ColumnType.String, 255, primaryKey: false, nullable: false, ColumnCategory.Text, description: "The name of the file. This may contain a \"short name|long name\" pair."),
                new ColumnDefinition("MinVersion", ColumnType.String, 20, primaryKey: false, nullable: true, ColumnCategory.Text, description: "The minimum version of the file."),
                new ColumnDefinition("MaxVersion", ColumnType.String, 20, primaryKey: false, nullable: true, ColumnCategory.Text, description: "The maximum version of the file."),
                new ColumnDefinition("MinSize", ColumnType.Number, 4, primaryKey: false, nullable: true, ColumnCategory.Unknown, minValue: 0, maxValue: 2147483647, description: "The minimum size of the file."),
                new ColumnDefinition("MaxSize", ColumnType.Number, 4, primaryKey: false, nullable: true, ColumnCategory.Unknown, minValue: 0, maxValue: 2147483647, description: "The maximum size of the file. "),
                new ColumnDefinition("MinDate", ColumnType.Number, 4, primaryKey: false, nullable: true, ColumnCategory.Unknown, minValue: 0, maxValue: 2147483647, description: "The minimum creation date of the file."),
                new ColumnDefinition("MaxDate", ColumnType.Number, 4, primaryKey: false, nullable: true, ColumnCategory.Unknown, minValue: 0, maxValue: 2147483647, description: "The maximum creation date of the file."),
                new ColumnDefinition("Languages", ColumnType.String, 255, primaryKey: false, nullable: true, ColumnCategory.Language, description: "The languages supported by the file."),
            },
            tupleDefinitionName: TupleDefinitions.Signature.Name,
            tupleIdIsPrimaryKey: true
        );

        public static readonly TableDefinition TextStyle = new TableDefinition(
            "TextStyle",
            new[]
            {
                new ColumnDefinition("TextStyle", ColumnType.String, 72, primaryKey: true, nullable: false, ColumnCategory.Identifier, description: "Name of the style. The primary key of this table. This name is embedded in the texts to indicate a style change."),
                new ColumnDefinition("FaceName", ColumnType.String, 32, primaryKey: false, nullable: false, ColumnCategory.Text, description: "A string indicating the name of the font used. Required. The string must be at most 31 characters long.", forceLocalizable: true),
                new ColumnDefinition("Size", ColumnType.Number, 2, primaryKey: false, nullable: false, ColumnCategory.Unknown, minValue: 0, maxValue: 32767, description: "The size of the font used. This size is given in our units (1/12 of the system font height). Assuming that the system font is set to 12 point size, this is equivalent to the point size.", forceLocalizable: true),
                new ColumnDefinition("Color", ColumnType.Number, 4, primaryKey: false, nullable: true, ColumnCategory.Unknown, minValue: 0, maxValue: 16777215, description: "A long integer indicating the color of the string in the RGB format (Red, Green, Blue each 0-255, RGB = R + 256*G + 256^2*B)."),
                new ColumnDefinition("StyleBits", ColumnType.Number, 2, primaryKey: false, nullable: true, ColumnCategory.Unknown, minValue: 0, maxValue: 15, description: "A combination of style bits."),
            },
            tupleDefinitionName: TupleDefinitions.TextStyle.Name,
            tupleIdIsPrimaryKey: true
        );

        public static readonly TableDefinition TypeLib = new TableDefinition(
            "TypeLib",
            new[]
            {
                new ColumnDefinition("LibID", ColumnType.String, 38, primaryKey: true, nullable: false, ColumnCategory.Guid, description: "The GUID that represents the library."),
                new ColumnDefinition("Language", ColumnType.Number, 2, primaryKey: true, nullable: false, ColumnCategory.Unknown, minValue: 0, maxValue: 32767, description: "The language of the library."),
                new ColumnDefinition("Component_", ColumnType.String, 72, primaryKey: true, nullable: false, ColumnCategory.Identifier, keyTable: "Component", keyColumn: 1, description: "Required foreign key into the Component Table, specifying the component for which to return a path when called through LocateComponent.", modularizeType: ColumnModularizeType.Column),
                new ColumnDefinition("Version", ColumnType.Number, 4, primaryKey: false, nullable: true, ColumnCategory.Unknown, minValue: 0, maxValue: 16777215, description: "The version of the library. The minor version is in the lower 8 bits of the integer. The major version is in the next 16 bits. "),
                new ColumnDefinition("Description", ColumnType.Localized, 128, primaryKey: false, nullable: true, ColumnCategory.Text),
                new ColumnDefinition("Directory_", ColumnType.String, 72, primaryKey: false, nullable: true, ColumnCategory.Identifier, keyTable: "Directory", keyColumn: 1, description: "Optional. The foreign key into the Directory table denoting the path to the help file for the type library.", modularizeType: ColumnModularizeType.Column),
                new ColumnDefinition("Feature_", ColumnType.String, 38, primaryKey: false, nullable: false, ColumnCategory.Identifier, keyTable: "Feature", keyColumn: 1, description: "Required foreign key into the Feature Table, specifying the feature to validate or install in order for the type library to be operational."),
                new ColumnDefinition("Cost", ColumnType.Number, 4, primaryKey: false, nullable: true, ColumnCategory.Unknown, minValue: 0, maxValue: 2147483647, description: "The cost associated with the registration of the typelib. This column is currently optional."),
            },
            tupleDefinitionName: TupleDefinitions.TypeLib.Name,
            tupleIdIsPrimaryKey: false
        );

        public static readonly TableDefinition UIText = new TableDefinition(
            "UIText",
            new[]
            {
                new ColumnDefinition("Key", ColumnType.String, 72, primaryKey: true, nullable: false, ColumnCategory.Identifier, description: "A unique key that identifies the particular string."),
                new ColumnDefinition("Text", ColumnType.Localized, 255, primaryKey: false, nullable: true, ColumnCategory.Text, description: "The localized version of the string."),
            },
            tupleDefinitionName: TupleDefinitions.UIText.Name,
            tupleIdIsPrimaryKey: true
        );

        public static readonly TableDefinition Upgrade = new TableDefinition(
            "Upgrade",
            new[]
            {
                new ColumnDefinition("UpgradeCode", ColumnType.String, 38, primaryKey: true, nullable: false, ColumnCategory.Guid, description: "The UpgradeCode GUID belonging to the products in this set."),
                new ColumnDefinition("VersionMin", ColumnType.String, 20, primaryKey: true, nullable: true, ColumnCategory.Text, description: "The minimum ProductVersion of the products in this set.  The set may or may not include products with this particular version."),
                new ColumnDefinition("VersionMax", ColumnType.String, 20, primaryKey: true, nullable: true, ColumnCategory.Text, description: "The maximum ProductVersion of the products in this set.  The set may or may not include products with this particular version."),
                new ColumnDefinition("Language", ColumnType.String, 255, primaryKey: true, nullable: true, ColumnCategory.Language, description: "A comma-separated list of languages for either products in this set or products not in this set.", forceLocalizable: true),
                new ColumnDefinition("Attributes", ColumnType.Number, 4, primaryKey: true, nullable: false, ColumnCategory.Unknown, minValue: 0, maxValue: 2147483647, description: "The attributes of this product set."),
                new ColumnDefinition("Remove", ColumnType.String, 255, primaryKey: false, nullable: true, ColumnCategory.Formatted, description: "The list of features to remove when uninstalling a product from this set.  The default is \"ALL\"."),
                new ColumnDefinition("ActionProperty", ColumnType.String, 72, primaryKey: false, nullable: false, ColumnCategory.UpperCase, description: "The property to set when a product in this set is found."),
            },
            tupleDefinitionName: TupleDefinitions.Upgrade.Name,
            tupleIdIsPrimaryKey: false
        );

        public static readonly TableDefinition Verb = new TableDefinition(
            "Verb",
            new[]
            {
                new ColumnDefinition("Extension_", ColumnType.String, 255, primaryKey: true, nullable: false, ColumnCategory.Text, keyTable: "Extension", keyColumn: 1, description: "The extension associated with the table row."),
                new ColumnDefinition("Verb", ColumnType.String, 32, primaryKey: true, nullable: false, ColumnCategory.Text, description: "The verb for the command."),
                new ColumnDefinition("Sequence", ColumnType.Number, 2, primaryKey: false, nullable: true, ColumnCategory.Unknown, minValue: 0, maxValue: 32767, description: "Order within the verbs for a particular extension. Also used simply to specify the default verb."),
                new ColumnDefinition("Command", ColumnType.Localized, 255, primaryKey: false, nullable: true, ColumnCategory.Formatted, description: "The command text.", modularizeType: ColumnModularizeType.Property),
                new ColumnDefinition("Argument", ColumnType.Localized, 255, primaryKey: false, nullable: true, ColumnCategory.Formatted, description: "Optional value for the command arguments.", modularizeType: ColumnModularizeType.Property),
            },
            tupleDefinitionName: TupleDefinitions.Verb.Name,
            tupleIdIsPrimaryKey: false
        );

        public static readonly TableDefinition ModuleAdminExecuteSequence = new TableDefinition(
            "ModuleAdminExecuteSequence",
            new[]
            {
                new ColumnDefinition("Action", ColumnType.String, 64, primaryKey: true, nullable: false, ColumnCategory.Identifier, description: "Action to insert", modularizeType: ColumnModularizeType.Column),
                new ColumnDefinition("Sequence", ColumnType.Number, 2, primaryKey: false, nullable: true, ColumnCategory.Unknown, minValue: -4, maxValue: 32767, description: "Standard Sequence number"),
                new ColumnDefinition("BaseAction", ColumnType.String, 64, primaryKey: false, nullable: true, ColumnCategory.Identifier, keyTable: "ModuleAdminExecuteSequence", keyColumn: 1, description: "Base action to determine insert location.", modularizeType: ColumnModularizeType.Column),
                new ColumnDefinition("After", ColumnType.Number, 2, primaryKey: false, nullable: true, ColumnCategory.Unknown, minValue: 0, maxValue: 1, description: "Before (0) or After (1)"),
                new ColumnDefinition("Condition", ColumnType.String, 255, primaryKey: false, nullable: true, ColumnCategory.Condition, modularizeType: ColumnModularizeType.Condition, forceLocalizable: true),
            },
            tupleIdIsPrimaryKey: true
        );

        public static readonly TableDefinition ModuleAdminUISequence = new TableDefinition(
            "ModuleAdminUISequence",
            new[]
            {
                new ColumnDefinition("Action", ColumnType.String, 64, primaryKey: true, nullable: false, ColumnCategory.Identifier, description: "Action to insert", modularizeType: ColumnModularizeType.Column),
                new ColumnDefinition("Sequence", ColumnType.Number, 2, primaryKey: false, nullable: true, ColumnCategory.Unknown, minValue: -4, maxValue: 32767, description: "Standard Sequence number"),
                new ColumnDefinition("BaseAction", ColumnType.String, 64, primaryKey: false, nullable: true, ColumnCategory.Identifier, keyTable: "ModuleAdminUISequence", keyColumn: 1, description: "Base action to determine insert location.", modularizeType: ColumnModularizeType.Column),
                new ColumnDefinition("After", ColumnType.Number, 2, primaryKey: false, nullable: true, ColumnCategory.Unknown, minValue: 0, maxValue: 1, description: "Before (0) or After (1)"),
                new ColumnDefinition("Condition", ColumnType.String, 255, primaryKey: false, nullable: true, ColumnCategory.Condition, modularizeType: ColumnModularizeType.Condition, forceLocalizable: true),
            },
            tupleIdIsPrimaryKey: true
        );

        public static readonly TableDefinition ModuleAdvtExecuteSequence = new TableDefinition(
            "ModuleAdvtExecuteSequence",
            new[]
            {
                new ColumnDefinition("Action", ColumnType.String, 64, primaryKey: true, nullable: false, ColumnCategory.Identifier, description: "Action to insert", modularizeType: ColumnModularizeType.Column),
                new ColumnDefinition("Sequence", ColumnType.Number, 2, primaryKey: false, nullable: true, ColumnCategory.Unknown, minValue: -4, maxValue: 32767, description: "Standard Sequence number"),
                new ColumnDefinition("BaseAction", ColumnType.String, 64, primaryKey: false, nullable: true, ColumnCategory.Identifier, keyTable: "ModuleAdvtExecuteSequence", keyColumn: 1, description: "Base action to determine insert location.", modularizeType: ColumnModularizeType.Column),
                new ColumnDefinition("After", ColumnType.Number, 2, primaryKey: false, nullable: true, ColumnCategory.Unknown, minValue: 0, maxValue: 1, description: "Before (0) or After (1)"),
                new ColumnDefinition("Condition", ColumnType.String, 255, primaryKey: false, nullable: true, ColumnCategory.Condition, modularizeType: ColumnModularizeType.Condition, forceLocalizable: true),
            },
            tupleIdIsPrimaryKey: true
        );

        public static readonly TableDefinition ModuleAdvtUISequence = new TableDefinition(
            "ModuleAdvtUISequence",
            new[]
            {
                new ColumnDefinition("Action", ColumnType.String, 64, primaryKey: true, nullable: false, ColumnCategory.Identifier, description: "Action to insert", modularizeType: ColumnModularizeType.Column),
                new ColumnDefinition("Sequence", ColumnType.Number, 2, primaryKey: false, nullable: true, ColumnCategory.Unknown, minValue: -4, maxValue: 32767, description: "Standard Sequence number"),
                new ColumnDefinition("BaseAction", ColumnType.String, 64, primaryKey: false, nullable: true, ColumnCategory.Identifier, keyTable: "ModuleAdvtUISequence", keyColumn: 1, description: "Base action to determine insert location.", modularizeType: ColumnModularizeType.Column),
                new ColumnDefinition("After", ColumnType.Number, 2, primaryKey: false, nullable: true, ColumnCategory.Unknown, minValue: 0, maxValue: 1, description: "Before (0) or After (1)"),
                new ColumnDefinition("Condition", ColumnType.String, 255, primaryKey: false, nullable: true, ColumnCategory.Condition, modularizeType: ColumnModularizeType.Condition, forceLocalizable: true),
            },
            tupleIdIsPrimaryKey: true
        );

        public static readonly TableDefinition ModuleComponents = new TableDefinition(
            "ModuleComponents",
            new[]
            {
                new ColumnDefinition("Component", ColumnType.String, 72, primaryKey: true, nullable: false, ColumnCategory.Identifier, keyTable: "Component", keyColumn: 1, description: "Component contained in the module.", modularizeType: ColumnModularizeType.Column),
                new ColumnDefinition("ModuleID", ColumnType.String, 72, primaryKey: true, nullable: false, ColumnCategory.Identifier, keyTable: "ModuleSignature", keyColumn: 1, description: "Module containing the component.", modularizeType: ColumnModularizeType.Column),
                new ColumnDefinition("Language", ColumnType.Number, 2, primaryKey: true, nullable: false, ColumnCategory.Unknown, keyTable: "ModuleSignature", keyColumn: 2, description: "Default language ID for module (may be changed by transform).", forceLocalizable: true),
            },
            tupleDefinitionName: TupleDefinitions.ModuleComponents.Name,
            tupleIdIsPrimaryKey: false
        );

        public static readonly TableDefinition ModuleSignature = new TableDefinition(
            "ModuleSignature",
            new[]
            {
                new ColumnDefinition("ModuleID", ColumnType.String, 72, primaryKey: true, nullable: false, ColumnCategory.Identifier, description: "Module identifier (String.GUID).", modularizeType: ColumnModularizeType.Column),
                new ColumnDefinition("Language", ColumnType.Number, 2, primaryKey: true, nullable: false, ColumnCategory.Unknown, description: "Default decimal language of module.", forceLocalizable: true),
                new ColumnDefinition("Version", ColumnType.String, 32, primaryKey: false, nullable: false, ColumnCategory.Version, description: "Version of the module."),
            },
            tupleDefinitionName: TupleDefinitions.ModuleSignature.Name,
            tupleIdIsPrimaryKey: false
        );

        public static readonly TableDefinition ModuleConfiguration = new TableDefinition(
            "ModuleConfiguration",
            new[]
            {
                new ColumnDefinition("Name", ColumnType.String, 72, primaryKey: true, nullable: false, ColumnCategory.Identifier, description: "Unique identifier for this row."),
                new ColumnDefinition("Format", ColumnType.Number, 2, primaryKey: false, nullable: false, ColumnCategory.Unknown, minValue: 0, maxValue: 3, description: "Format of this item."),
                new ColumnDefinition("Type", ColumnType.String, 72, primaryKey: false, nullable: true, ColumnCategory.Identifier, description: "Additional type information for this item."),
                new ColumnDefinition("ContextData", ColumnType.Localized, 0, primaryKey: false, nullable: true, ColumnCategory.Text, description: "Additional context information about this item."),
                new ColumnDefinition("DefaultValue", ColumnType.Localized, 0, primaryKey: false, nullable: true, ColumnCategory.Text, description: "Default value for this item."),
                new ColumnDefinition("Attributes", ColumnType.Number, 4, primaryKey: false, nullable: true, ColumnCategory.Unknown, minValue: 0, maxValue: 3, description: "Additional type-specific attributes."),
                new ColumnDefinition("DisplayName", ColumnType.Localized, 72, primaryKey: false, nullable: true, ColumnCategory.Text, description: "A short human-readable name for this item."),
                new ColumnDefinition("Description", ColumnType.Localized, 0, primaryKey: false, nullable: true, ColumnCategory.Text, description: "A human-readable description."),
                new ColumnDefinition("HelpLocation", ColumnType.String, 0, primaryKey: false, nullable: true, ColumnCategory.Text, description: "Filename or namespace of the context-sensitive help for this item."),
                new ColumnDefinition("HelpKeyword", ColumnType.String, 0, primaryKey: false, nullable: true, ColumnCategory.Text, description: "Keyword index into the HelpLocation for this item."),
            },
            tupleDefinitionName: TupleDefinitions.ModuleConfiguration.Name,
            tupleIdIsPrimaryKey: true
        );

        public static readonly TableDefinition ModuleDependency = new TableDefinition(
            "ModuleDependency",
            new[]
            {
                new ColumnDefinition("ModuleID", ColumnType.String, 72, primaryKey: true, nullable: false, ColumnCategory.Identifier, keyTable: "ModuleSignature", keyColumn: 1, description: "Module requiring the dependency.", modularizeType: ColumnModularizeType.Column),
                new ColumnDefinition("ModuleLanguage", ColumnType.Number, 2, primaryKey: true, nullable: false, ColumnCategory.Unknown, keyTable: "ModuleSignature", keyColumn: 2, description: "Language of module requiring the dependency.", forceLocalizable: true),
                new ColumnDefinition("RequiredID", ColumnType.String, 72, primaryKey: true, nullable: false, ColumnCategory.Unknown, description: "String.GUID of required module."),
                new ColumnDefinition("RequiredLanguage", ColumnType.Number, 2, primaryKey: true, nullable: false, ColumnCategory.Unknown, description: "LanguageID of the required module.", forceLocalizable: true),
                new ColumnDefinition("RequiredVersion", ColumnType.String, 32, primaryKey: false, nullable: true, ColumnCategory.Version, description: "Version of the required version."),
            },
            tupleDefinitionName: TupleDefinitions.ModuleDependency.Name,
            tupleIdIsPrimaryKey: false
        );

        public static readonly TableDefinition ModuleExclusion = new TableDefinition(
            "ModuleExclusion",
            new[]
            {
                new ColumnDefinition("ModuleID", ColumnType.String, 72, primaryKey: true, nullable: false, ColumnCategory.Identifier, keyTable: "ModuleSignature", keyColumn: 1, description: "String.GUID of module with exclusion requirement.", modularizeType: ColumnModularizeType.Column),
                new ColumnDefinition("ModuleLanguage", ColumnType.Number, 2, primaryKey: true, nullable: false, ColumnCategory.Unknown, keyTable: "ModuleSignature", keyColumn: 2, description: "LanguageID of module with exclusion requirement.", forceLocalizable: true),
                new ColumnDefinition("ExcludedID", ColumnType.String, 72, primaryKey: true, nullable: false, ColumnCategory.Unknown, description: "String.GUID of excluded module."),
                new ColumnDefinition("ExcludedLanguage", ColumnType.Number, 2, primaryKey: true, nullable: false, ColumnCategory.Unknown, description: "Language of excluded module.", forceLocalizable: true),
                new ColumnDefinition("ExcludedMinVersion", ColumnType.String, 32, primaryKey: false, nullable: true, ColumnCategory.Version, description: "Minimum version of excluded module."),
                new ColumnDefinition("ExcludedMaxVersion", ColumnType.String, 32, primaryKey: false, nullable: true, ColumnCategory.Version, description: "Maximum version of excluded module."),
            },
            tupleDefinitionName: TupleDefinitions.ModuleExclusion.Name,
            tupleIdIsPrimaryKey: false
        );

        public static readonly TableDefinition ModuleIgnoreTable = new TableDefinition(
            "ModuleIgnoreTable",
            new[]
            {
                new ColumnDefinition("Table", ColumnType.String, 72, primaryKey: true, nullable: false, ColumnCategory.Identifier, description: "Table name to ignore during merge operation."),
            },
            tupleDefinitionName: TupleDefinitions.ModuleIgnoreTable.Name,
            tupleIdIsPrimaryKey: true
        );

        public static readonly TableDefinition ModuleInstallExecuteSequence = new TableDefinition(
            "ModuleInstallExecuteSequence",
            new[]
            {
                new ColumnDefinition("Action", ColumnType.String, 64, primaryKey: true, nullable: false, ColumnCategory.Identifier, description: "Action to insert", modularizeType: ColumnModularizeType.Column),
                new ColumnDefinition("Sequence", ColumnType.Number, 2, primaryKey: false, nullable: true, ColumnCategory.Unknown, minValue: -4, maxValue: 32767, description: "Standard Sequence number"),
                new ColumnDefinition("BaseAction", ColumnType.String, 64, primaryKey: false, nullable: true, ColumnCategory.Identifier, keyTable: "ModuleInstallExecuteSequence", keyColumn: 1, description: "Base action to determine insert location.", modularizeType: ColumnModularizeType.Column),
                new ColumnDefinition("After", ColumnType.Number, 2, primaryKey: false, nullable: true, ColumnCategory.Unknown, minValue: 0, maxValue: 1, description: "Before (0) or After (1)"),
                new ColumnDefinition("Condition", ColumnType.String, 255, primaryKey: false, nullable: true, ColumnCategory.Condition, modularizeType: ColumnModularizeType.Condition, forceLocalizable: true),
            },
            tupleIdIsPrimaryKey: true
        );

        public static readonly TableDefinition ModuleInstallUISequence = new TableDefinition(
            "ModuleInstallUISequence",
            new[]
            {
                new ColumnDefinition("Action", ColumnType.String, 64, primaryKey: true, nullable: false, ColumnCategory.Identifier, description: "Action to insert", modularizeType: ColumnModularizeType.Column),
                new ColumnDefinition("Sequence", ColumnType.Number, 2, primaryKey: false, nullable: true, ColumnCategory.Unknown, minValue: -4, maxValue: 32767, description: "Standard Sequence number"),
                new ColumnDefinition("BaseAction", ColumnType.String, 64, primaryKey: false, nullable: true, ColumnCategory.Identifier, keyTable: "ModuleInstallUISequence", keyColumn: 1, description: "Base action to determine insert location.", modularizeType: ColumnModularizeType.Column),
                new ColumnDefinition("After", ColumnType.Number, 2, primaryKey: false, nullable: true, ColumnCategory.Unknown, minValue: 0, maxValue: 1, description: "Before (0) or After (1)"),
                new ColumnDefinition("Condition", ColumnType.String, 255, primaryKey: false, nullable: true, ColumnCategory.Condition, modularizeType: ColumnModularizeType.Condition, forceLocalizable: true),
            },
            tupleIdIsPrimaryKey: true
        );

        public static readonly TableDefinition ModuleSubstitution = new TableDefinition(
            "ModuleSubstitution",
            new[]
            {
                new ColumnDefinition("Table", ColumnType.String, 72, primaryKey: true, nullable: false, ColumnCategory.Identifier, description: "Table containing the data to be modified."),
                new ColumnDefinition("Row", ColumnType.String, 0, primaryKey: true, nullable: false, ColumnCategory.Text, description: "Row containing the data to be modified.", modularizeType: ColumnModularizeType.SemicolonDelimited),
                new ColumnDefinition("Column", ColumnType.String, 72, primaryKey: true, nullable: false, ColumnCategory.Identifier, description: "Column containing the data to be modified."),
                new ColumnDefinition("Value", ColumnType.Localized, 0, primaryKey: false, nullable: true, ColumnCategory.Text, description: "Template for modification data."),
            },
            tupleDefinitionName: TupleDefinitions.ModuleSubstitution.Name,
            tupleIdIsPrimaryKey: false
        );

        public static readonly TableDefinition Properties = new TableDefinition(
            "Properties",
            new[]
            {
                new ColumnDefinition("Name", ColumnType.String, 72, primaryKey: true, nullable: false, ColumnCategory.Text, description: "Primary key, non-localized token"),
                new ColumnDefinition("Value", ColumnType.String, 0, primaryKey: false, nullable: false, ColumnCategory.Text, description: "Value of the property"),
            },
            tupleDefinitionName: TupleDefinitions.Properties.Name,
            tupleIdIsPrimaryKey: false
        );

        public static readonly TableDefinition ImageFamilies = new TableDefinition(
            "ImageFamilies",
            new[]
            {
                new ColumnDefinition("Family", ColumnType.String, 8, primaryKey: true, nullable: false, ColumnCategory.Text, description: "Primary key"),
                new ColumnDefinition("MediaSrcPropName", ColumnType.String, 72, primaryKey: false, nullable: true, ColumnCategory.Text),
                new ColumnDefinition("MediaDiskId", ColumnType.Number, 0, primaryKey: false, nullable: true, ColumnCategory.Integer),
                new ColumnDefinition("FileSequenceStart", ColumnType.Number, 4, primaryKey: false, nullable: true, ColumnCategory.Integer, minValue: 1, maxValue: 214743647),
                new ColumnDefinition("DiskPrompt", ColumnType.String, 128, primaryKey: false, nullable: true, ColumnCategory.Text, forceLocalizable: true),
                new ColumnDefinition("VolumeLabel", ColumnType.String, 32, primaryKey: false, nullable: true, ColumnCategory.Text),
            },
            tupleDefinitionName: TupleDefinitions.ImageFamilies.Name,
            tupleIdIsPrimaryKey: false
        );

        public static readonly TableDefinition UpgradedImages = new TableDefinition(
            "UpgradedImages",
            new[]
            {
                new ColumnDefinition("Upgraded", ColumnType.String, 13, primaryKey: true, nullable: false, ColumnCategory.Text, description: "Primary key"),
                new ColumnDefinition("MsiPath", ColumnType.String, 255, primaryKey: false, nullable: false, ColumnCategory.Text),
                new ColumnDefinition("PatchMsiPath", ColumnType.String, 255, primaryKey: false, nullable: true, ColumnCategory.Text),
                new ColumnDefinition("SymbolPaths", ColumnType.String, 255, primaryKey: false, nullable: true, ColumnCategory.Text),
                new ColumnDefinition("Family", ColumnType.String, 8, primaryKey: false, nullable: false, ColumnCategory.Text, keyTable: "ImageFamilies", keyColumn: 1, description: "Foreign key, Family to which this image belongs"),
            },
            tupleDefinitionName: TupleDefinitions.UpgradedImages.Name,
            tupleIdIsPrimaryKey: false
        );

        public static readonly TableDefinition UpgradedFilesToIgnore = new TableDefinition(
            "UpgradedFilesToIgnore",
            new[]
            {
                new ColumnDefinition("Upgraded", ColumnType.String, 13, primaryKey: true, nullable: false, ColumnCategory.Text, keyTable: "UpgradedImages", keyColumn: 1, description: "Foreign key, Upgraded image"),
                new ColumnDefinition("FTK", ColumnType.String, 255, primaryKey: true, nullable: false, ColumnCategory.Text, keyTable: "File", keyColumn: 1, description: "Foreign key, File to ignore", modularizeType: ColumnModularizeType.Column),
            },
            tupleDefinitionName: TupleDefinitions.UpgradedFilesToIgnore.Name,
            tupleIdIsPrimaryKey: false
        );

        public static readonly TableDefinition UpgradedFiles_OptionalData = new TableDefinition(
            "UpgradedFiles_OptionalData",
            new[]
            {
                new ColumnDefinition("Upgraded", ColumnType.String, 13, primaryKey: true, nullable: false, ColumnCategory.Text, keyTable: "UpgradedImages", keyColumn: 1, description: "Foreign key, Upgraded image"),
                new ColumnDefinition("FTK", ColumnType.String, 255, primaryKey: true, nullable: false, ColumnCategory.Text, keyTable: "File", keyColumn: 1, description: "Foreign key, File to ignore", modularizeType: ColumnModularizeType.Column),
                new ColumnDefinition("SymbolPaths", ColumnType.String, 255, primaryKey: false, nullable: true, ColumnCategory.Text),
                new ColumnDefinition("AllowIgnoreOnPatchError", ColumnType.Number, 0, primaryKey: false, nullable: true, ColumnCategory.Integer),
                new ColumnDefinition("IncludeWholeFile", ColumnType.Number, 0, primaryKey: false, nullable: true, ColumnCategory.Integer),
            },
            tupleDefinitionName: TupleDefinitions.UpgradedFilesOptionalData.Name,
            tupleIdIsPrimaryKey: false
        );

        public static readonly TableDefinition TargetImages = new TableDefinition(
            "TargetImages",
            new[]
            {
                new ColumnDefinition("Target", ColumnType.String, 13, primaryKey: true, nullable: false, ColumnCategory.Text),
                new ColumnDefinition("MsiPath", ColumnType.String, 255, primaryKey: false, nullable: false, ColumnCategory.Text),
                new ColumnDefinition("SymbolPaths", ColumnType.String, 255, primaryKey: false, nullable: true, ColumnCategory.Text),
                new ColumnDefinition("Upgraded", ColumnType.String, 13, primaryKey: false, nullable: false, ColumnCategory.Text, keyTable: "UpgradedImages", keyColumn: 1, description: "Foreign key, Upgraded image"),
                new ColumnDefinition("Order", ColumnType.Number, 0, primaryKey: false, nullable: false, ColumnCategory.Integer),
                new ColumnDefinition("ProductValidateFlags", ColumnType.String, 16, primaryKey: false, nullable: true, ColumnCategory.Text),
                new ColumnDefinition("IgnoreMissingSrcFiles", ColumnType.Number, 0, primaryKey: false, nullable: false, ColumnCategory.Integer),
            },
            tupleDefinitionName: TupleDefinitions.TargetImages.Name,
            tupleIdIsPrimaryKey: false
        );

        public static readonly TableDefinition TargetFiles_OptionalData = new TableDefinition(
            "TargetFiles_OptionalData",
            new[]
            {
                new ColumnDefinition("Target", ColumnType.String, 13, primaryKey: true, nullable: false, ColumnCategory.Text, keyTable: "TargetImages", keyColumn: 1, description: "Foreign key, Target image"),
                new ColumnDefinition("FTK", ColumnType.String, 255, primaryKey: true, nullable: false, ColumnCategory.Text, keyTable: "File", keyColumn: 1, description: "Foreign key, File to ignore", modularizeType: ColumnModularizeType.Column),
                new ColumnDefinition("SymbolPaths", ColumnType.String, 255, primaryKey: false, nullable: true, ColumnCategory.Text),
                new ColumnDefinition("IgnoreOffsets", ColumnType.String, 255, primaryKey: false, nullable: true, ColumnCategory.Text),
                new ColumnDefinition("IgnoreLengths", ColumnType.String, 255, primaryKey: false, nullable: true, ColumnCategory.Text),
                new ColumnDefinition("RetainOffsets", ColumnType.String, 255, primaryKey: false, nullable: true, ColumnCategory.Text),
            },
            tupleDefinitionName: TupleDefinitions.TargetFilesOptionalData.Name,
            tupleIdIsPrimaryKey: false
        );

        public static readonly TableDefinition FamilyFileRanges = new TableDefinition(
            "FamilyFileRanges",
            new[]
            {
                new ColumnDefinition("Family", ColumnType.String, 8, primaryKey: true, nullable: false, ColumnCategory.Text, keyTable: "ImageFamilies", keyColumn: 1, description: "Foreign key, Family"),
                new ColumnDefinition("FTK", ColumnType.String, 255, primaryKey: true, nullable: false, ColumnCategory.Text, keyTable: "File", keyColumn: 1, description: "Foreign key, File to ignore", modularizeType: ColumnModularizeType.Column),
                new ColumnDefinition("RetainOffsets", ColumnType.String, 128, primaryKey: false, nullable: false, ColumnCategory.Text),
                new ColumnDefinition("RetainLengths", ColumnType.String, 128, primaryKey: false, nullable: false, ColumnCategory.Text),
            },
            tupleDefinitionName: TupleDefinitions.FamilyFileRanges.Name,
            tupleIdIsPrimaryKey: false
        );

        public static readonly TableDefinition ExternalFiles = new TableDefinition(
            "ExternalFiles",
            new[]
            {
                new ColumnDefinition("Family", ColumnType.String, 8, primaryKey: true, nullable: false, ColumnCategory.Text, keyTable: "ImageFamilies", keyColumn: 1, description: "Foreign key, Family"),
                new ColumnDefinition("FTK", ColumnType.String, 255, primaryKey: true, nullable: false, ColumnCategory.Text, keyTable: "File", keyColumn: 1, description: "Foreign key, File to ignore", modularizeType: ColumnModularizeType.Column),
                new ColumnDefinition("FilePath", ColumnType.String, 255, primaryKey: true, nullable: false, ColumnCategory.Text),
                new ColumnDefinition("SymbolPaths", ColumnType.String, 255, primaryKey: false, nullable: true, ColumnCategory.Text),
                new ColumnDefinition("IgnoreOffsets", ColumnType.String, 255, primaryKey: false, nullable: true, ColumnCategory.Text),
                new ColumnDefinition("IgnoreLengths", ColumnType.String, 255, primaryKey: false, nullable: true, ColumnCategory.Text),
                new ColumnDefinition("RetainOffsets", ColumnType.String, 255, primaryKey: false, nullable: true, ColumnCategory.Text),
                new ColumnDefinition("Order", ColumnType.Number, 0, primaryKey: false, nullable: false, ColumnCategory.Integer),
            },
            tupleDefinitionName: TupleDefinitions.ExternalFiles.Name,
            tupleIdIsPrimaryKey: false
        );

        public static readonly TableDefinition WixAction = new TableDefinition(
            "WixAction",
            new[]
            {
                new ColumnDefinition("SequenceTable", ColumnType.String, 62, primaryKey: true, nullable: false, ColumnCategory.Unknown),
                new ColumnDefinition("Action", ColumnType.String, 72, primaryKey: true, nullable: false, ColumnCategory.Unknown),
                new ColumnDefinition("Condition", ColumnType.String, 255, primaryKey: false, nullable: true, ColumnCategory.Unknown, forceLocalizable: true),
                new ColumnDefinition("Sequence", ColumnType.Number, 2, primaryKey: false, nullable: true, ColumnCategory.Unknown),
                new ColumnDefinition("Before", ColumnType.String, 72, primaryKey: false, nullable: true, ColumnCategory.Unknown),
                new ColumnDefinition("After", ColumnType.String, 72, primaryKey: false, nullable: true, ColumnCategory.Unknown),
                new ColumnDefinition("Overridable", ColumnType.Number, 2, primaryKey: false, nullable: true, ColumnCategory.Unknown),
            },
            unreal: true,
            tupleDefinitionName: TupleDefinitions.WixAction.Name,
            tupleIdIsPrimaryKey: false
        );

        public static readonly TableDefinition WixBBControl = new TableDefinition(
            "WixBBControl",
            new[]
            {
                new ColumnDefinition("Billboard_", ColumnType.String, 50, primaryKey: true, nullable: false, ColumnCategory.Unknown, modularizeType: ColumnModularizeType.Column),
                new ColumnDefinition("BBControl_", ColumnType.String, 50, primaryKey: true, nullable: false, ColumnCategory.Unknown),
                new ColumnDefinition("SourceFile", ColumnType.Object, 0, primaryKey: false, nullable: false, ColumnCategory.Unknown),
            },
            unreal: true,
            tupleIdIsPrimaryKey: false
        );

        public static readonly TableDefinition WixComplexReference = new TableDefinition(
            "WixComplexReference",
            new[]
            {
                new ColumnDefinition("Parent", ColumnType.String, 0, primaryKey: false, nullable: false, ColumnCategory.Unknown, forceLocalizable: true),
                new ColumnDefinition("ParentAttributes", ColumnType.Number, 4, primaryKey: false, nullable: false, ColumnCategory.Unknown),
                new ColumnDefinition("ParentLanguage", ColumnType.String, 0, primaryKey: false, nullable: true, ColumnCategory.Unknown),
                new ColumnDefinition("Child", ColumnType.String, 0, primaryKey: false, nullable: false, ColumnCategory.Unknown, forceLocalizable: true),
                new ColumnDefinition("ChildAttributes", ColumnType.Number, 4, primaryKey: false, nullable: false, ColumnCategory.Unknown),
                new ColumnDefinition("Attributes", ColumnType.Number, 4, primaryKey: false, nullable: false, ColumnCategory.Unknown),
            },
            unreal: true,
            tupleDefinitionName: TupleDefinitions.WixComplexReference.Name,
            tupleIdIsPrimaryKey: false
        );

        public static readonly TableDefinition WixComponentGroup = new TableDefinition(
            "WixComponentGroup",
            new[]
            {
                new ColumnDefinition("WixComponentGroup", ColumnType.String, 0, primaryKey: true, nullable: false, ColumnCategory.Unknown),
            },
            unreal: true,
            tupleDefinitionName: TupleDefinitions.WixComponentGroup.Name,
            tupleIdIsPrimaryKey: false
        );

        public static readonly TableDefinition WixControl = new TableDefinition(
            "WixControl",
            new[]
            {
                new ColumnDefinition("Dialog_", ColumnType.String, 72, primaryKey: true, nullable: false, ColumnCategory.Unknown, modularizeType: ColumnModularizeType.Column),
                new ColumnDefinition("Control_", ColumnType.String, 50, primaryKey: true, nullable: false, ColumnCategory.Unknown),
                new ColumnDefinition("SourceFile", ColumnType.Object, 0, primaryKey: false, nullable: false, ColumnCategory.Unknown),
            },
            unreal: true,
            tupleIdIsPrimaryKey: false
        );

        public static readonly TableDefinition WixCustomRow = new TableDefinition(
            "WixCustomRow",
            new[]
            {
                new ColumnDefinition("Table", ColumnType.String, 62, primaryKey: false, nullable: false, ColumnCategory.Unknown),
                new ColumnDefinition("FieldData", ColumnType.String, 0, primaryKey: false, nullable: false, ColumnCategory.Unknown),
            },
            unreal: true,
            tupleDefinitionName: TupleDefinitions.WixCustomRow.Name,
            tupleIdIsPrimaryKey: false
        );

        public static readonly TableDefinition WixCustomTable = new TableDefinition(
            "WixCustomTable",
            new[]
            {
                new ColumnDefinition("Table", ColumnType.String, 62, primaryKey: true, nullable: false, ColumnCategory.Unknown),
                new ColumnDefinition("ColumnCount", ColumnType.Number, 2, primaryKey: false, nullable: false, ColumnCategory.Unknown),
                new ColumnDefinition("ColumnNames", ColumnType.String, 0, primaryKey: false, nullable: false, ColumnCategory.Unknown),
                new ColumnDefinition("ColumnTypes", ColumnType.String, 0, primaryKey: false, nullable: false, ColumnCategory.Unknown),
                new ColumnDefinition("PrimaryKeys", ColumnType.String, 0, primaryKey: false, nullable: false, ColumnCategory.Unknown),
                new ColumnDefinition("MinValues", ColumnType.String, 0, primaryKey: false, nullable: false, ColumnCategory.Unknown),
                new ColumnDefinition("MaxValues", ColumnType.String, 0, primaryKey: false, nullable: false, ColumnCategory.Unknown),
                new ColumnDefinition("KeyTables", ColumnType.String, 0, primaryKey: false, nullable: false, ColumnCategory.Unknown),
                new ColumnDefinition("KeyColumns", ColumnType.String, 0, primaryKey: false, nullable: false, ColumnCategory.Unknown),
                new ColumnDefinition("Categories", ColumnType.String, 0, primaryKey: false, nullable: false, ColumnCategory.Unknown),
                new ColumnDefinition("Sets", ColumnType.String, 0, primaryKey: false, nullable: false, ColumnCategory.Unknown),
                new ColumnDefinition("Descriptions", ColumnType.String, 0, primaryKey: false, nullable: false, ColumnCategory.Unknown),
                new ColumnDefinition("Modularizations", ColumnType.String, 0, primaryKey: false, nullable: false, ColumnCategory.Unknown),
                new ColumnDefinition("BootstrapperApplicationData", ColumnType.Number, 2, primaryKey: false, nullable: false, ColumnCategory.Unknown),
            },
            unreal: true,
            tupleDefinitionName: TupleDefinitions.WixCustomTable.Name,
            tupleIdIsPrimaryKey: true
        );

        public static readonly TableDefinition WixDirectory = new TableDefinition(
            "WixDirectory",
            new[]
            {
                new ColumnDefinition("Directory_", ColumnType.String, 0, primaryKey: true, nullable: false, ColumnCategory.Unknown, modularizeType: ColumnModularizeType.Column),
                new ColumnDefinition("ComponentGuidGenerationSeed", ColumnType.String, 38, primaryKey: false, nullable: true, ColumnCategory.Unknown),
            },
            unreal: true,
            tupleIdIsPrimaryKey: false
        );

        public static readonly TableDefinition WixEnsureTable = new TableDefinition(
            "WixEnsureTable",
            new[]
            {
                new ColumnDefinition("Table", ColumnType.String, 31, primaryKey: false, nullable: false, ColumnCategory.Unknown),
            },
            unreal: true,
            tupleDefinitionName: TupleDefinitions.WixEnsureTable.Name,
            tupleIdIsPrimaryKey: false
        );

        public static readonly TableDefinition WixFeatureGroup = new TableDefinition(
            "WixFeatureGroup",
            new[]
            {
                new ColumnDefinition("WixFeatureGroup", ColumnType.String, 0, primaryKey: true, nullable: false, ColumnCategory.Unknown),
            },
            unreal: true,
            tupleDefinitionName: TupleDefinitions.WixFeatureGroup.Name,
            tupleIdIsPrimaryKey: true
        );

        public static readonly TableDefinition WixPatchFamilyGroup = new TableDefinition(
            "WixPatchFamilyGroup",
            new[]
            {
                new ColumnDefinition("WixPatchFamilyGroup", ColumnType.String, 0, primaryKey: true, nullable: false, ColumnCategory.Unknown),
            },
            unreal: true,
            tupleDefinitionName: TupleDefinitions.WixPatchFamilyGroup.Name,
            tupleIdIsPrimaryKey: false
        );

        public static readonly TableDefinition WixGroup = new TableDefinition(
            "WixGroup",
            new[]
            {
                new ColumnDefinition("ParentId", ColumnType.String, 0, primaryKey: true, nullable: false, ColumnCategory.Identifier, description: "Primary key used to identify a particular record in a parent table."),
                new ColumnDefinition("ParentType", ColumnType.String, 0, primaryKey: true, nullable: false, ColumnCategory.Unknown, description: "Primary key used to identify a particular parent type in a parent table."),
                new ColumnDefinition("ChildId", ColumnType.String, 0, primaryKey: true, nullable: false, ColumnCategory.Identifier, description: "Primary key used to identify a particular record in a child table."),
                new ColumnDefinition("ChildType", ColumnType.String, 0, primaryKey: true, nullable: false, ColumnCategory.Unknown, description: "Primary key used to identify a particular child type in a child table."),
            },
            unreal: true,
            tupleDefinitionName: TupleDefinitions.WixGroup.Name,
            tupleIdIsPrimaryKey: false
        );

        public static readonly TableDefinition WixFeatureModules = new TableDefinition(
            "WixFeatureModules",
            new[]
            {
                new ColumnDefinition("Feature_", ColumnType.String, 38, primaryKey: true, nullable: false, ColumnCategory.Unknown),
                new ColumnDefinition("WixMerge_", ColumnType.String, 72, primaryKey: true, nullable: false, ColumnCategory.Unknown),
            },
            unreal: true,
            tupleDefinitionName: TupleDefinitions.WixFeatureModules.Name,
            tupleIdIsPrimaryKey: false
        );

        public static readonly TableDefinition WixFile = new TableDefinition(
            "WixFile",
            new[]
            {
                new ColumnDefinition("File_", ColumnType.String, 0, primaryKey: true, nullable: false, ColumnCategory.Identifier, keyTable: "File", keyColumn: 1, modularizeType: ColumnModularizeType.Column),
                new ColumnDefinition("AssemblyType", ColumnType.Number, 2, primaryKey: false, nullable: false, ColumnCategory.Unknown, minValue: 0, maxValue: 1),
                new ColumnDefinition("File_AssemblyManifest", ColumnType.String, 72, primaryKey: false, nullable: true, ColumnCategory.Identifier, keyTable: "File", keyColumn: 1, modularizeType: ColumnModularizeType.Column),
                new ColumnDefinition("File_AssemblyApplication", ColumnType.String, 72, primaryKey: false, nullable: true, ColumnCategory.Identifier, keyTable: "File", keyColumn: 1, modularizeType: ColumnModularizeType.Column),
                new ColumnDefinition("Directory_", ColumnType.String, 72, primaryKey: false, nullable: false, ColumnCategory.Unknown, keyTable: "Directory", keyColumn: 1, modularizeType: ColumnModularizeType.Column),
                new ColumnDefinition("DiskId", ColumnType.Number, 4, primaryKey: false, nullable: true, ColumnCategory.Unknown),
                new ColumnDefinition("Source", ColumnType.Object, 0, primaryKey: false, nullable: false, ColumnCategory.Unknown),
                new ColumnDefinition("ProcessorArchitecture", ColumnType.String, 0, primaryKey: false, nullable: true, ColumnCategory.Unknown),
                new ColumnDefinition("PatchGroup", ColumnType.Number, 4, primaryKey: false, nullable: false, ColumnCategory.Unknown),
                new ColumnDefinition("Attributes", ColumnType.Number, 4, primaryKey: false, nullable: false, ColumnCategory.Unknown),
                new ColumnDefinition("PatchAttributes", ColumnType.Number, 4, primaryKey: false, nullable: true, ColumnCategory.Unknown),
                new ColumnDefinition("DeltaPatchHeaderSource", ColumnType.String, 0, primaryKey: false, nullable: true, ColumnCategory.Unknown),
            },
            unreal: true,
            tupleIdIsPrimaryKey: false
        );

        public static readonly TableDefinition WixBindUpdatedFiles = new TableDefinition(
            "WixBindUpdatedFiles",
            new[]
            {
                new ColumnDefinition("File_", ColumnType.String, 0, primaryKey: true, nullable: false, ColumnCategory.Identifier, keyTable: "File", keyColumn: 1, modularizeType: ColumnModularizeType.Column),
            },
            unreal: true,
            tupleDefinitionName: TupleDefinitions.WixBindUpdatedFiles.Name,
            tupleIdIsPrimaryKey: false
        );

        public static readonly TableDefinition WixBuildInfo = new TableDefinition(
            "WixBuildInfo",
            new[]
            {
                new ColumnDefinition("WixVersion", ColumnType.String, 20, primaryKey: false, nullable: false, ColumnCategory.Text, description: "Version number of WiX."),
                new ColumnDefinition("WixOutputFile", ColumnType.String, 0, primaryKey: false, nullable: true, ColumnCategory.Text, description: "Path to output file, if supplied."),
                new ColumnDefinition("WixProjectFile", ColumnType.String, 0, primaryKey: false, nullable: true, ColumnCategory.Text, description: "Path to .wixproj file, if supplied."),
                new ColumnDefinition("WixPdbFile", ColumnType.String, 0, primaryKey: false, nullable: true, ColumnCategory.Text, description: "Path to .wixpdb file, if supplied."),
            },
            unreal: true,
            tupleDefinitionName: TupleDefinitions.WixBuildInfo.Name,
            tupleIdIsPrimaryKey: false
        );

        public static readonly TableDefinition WixFragment = new TableDefinition(
            "WixFragment",
            new[]
            {
                new ColumnDefinition("WixFragment", ColumnType.String, 0, primaryKey: true, nullable: false, ColumnCategory.Unknown),
            },
            unreal: true,
            tupleDefinitionName: TupleDefinitions.WixFragment.Name,
            tupleIdIsPrimaryKey: true
        );

        public static readonly TableDefinition WixInstanceComponent = new TableDefinition(
            "WixInstanceComponent",
            new[]
            {
                new ColumnDefinition("Component_", ColumnType.String, 0, primaryKey: true, nullable: false, ColumnCategory.Unknown, modularizeType: ColumnModularizeType.Column),
            },
            unreal: true,
            tupleDefinitionName: TupleDefinitions.WixInstanceComponent.Name,
            tupleIdIsPrimaryKey: false
        );

        public static readonly TableDefinition WixInstanceTransforms = new TableDefinition(
            "WixInstanceTransforms",
            new[]
            {
                new ColumnDefinition("Id", ColumnType.String, 0, primaryKey: true, nullable: false, ColumnCategory.Unknown),
                new ColumnDefinition("PropertyId", ColumnType.String, 0, primaryKey: false, nullable: false, ColumnCategory.Unknown),
                new ColumnDefinition("ProductCode", ColumnType.String, 0, primaryKey: false, nullable: false, ColumnCategory.Guid),
                new ColumnDefinition("ProductName", ColumnType.Localized, 0, primaryKey: false, nullable: true, ColumnCategory.Unknown, forceLocalizable: true),
                new ColumnDefinition("UpgradeCode", ColumnType.String, 38, primaryKey: false, nullable: true, ColumnCategory.Guid),
            },
            unreal: true,
            tupleDefinitionName: TupleDefinitions.WixInstanceTransforms.Name,
            tupleIdIsPrimaryKey: true
        );

        public static readonly TableDefinition WixMedia = new TableDefinition(
            "WixMedia",
            new[]
            {
                new ColumnDefinition("DiskId_", ColumnType.Number, 2, primaryKey: true, nullable: false, ColumnCategory.Unknown),
                new ColumnDefinition("CompressionLevel", ColumnType.Number, 2, primaryKey: false, nullable: true, ColumnCategory.Unknown, minValue: 0, maxValue: 4),
                new ColumnDefinition("Layout", ColumnType.String, 0, primaryKey: false, nullable: true, ColumnCategory.Unknown),
            },
            unreal: true,
            tupleIdIsPrimaryKey: false
        );

        public static readonly TableDefinition WixMediaTemplate = new TableDefinition(
            "WixMediaTemplate",
            new[]
            {
                new ColumnDefinition("CabinetTemplate", ColumnType.String, 0, primaryKey: false, nullable: true, ColumnCategory.Unknown),
                new ColumnDefinition("CompressionLevel", ColumnType.Number, 2, primaryKey: false, nullable: true, ColumnCategory.Unknown, minValue: 0, maxValue: 4),
                new ColumnDefinition("DiskPrompt", ColumnType.String, 0, primaryKey: false, nullable: true, ColumnCategory.Unknown),
                new ColumnDefinition("VolumeLabel", ColumnType.String, 0, primaryKey: false, nullable: true, ColumnCategory.Unknown),
                new ColumnDefinition("MaximumUncompressedMediaSize", ColumnType.Number, 4, primaryKey: false, nullable: false, ColumnCategory.Unknown),
                new ColumnDefinition("MaximumCabinetSizeForLargeFileSplitting", ColumnType.Number, 4, primaryKey: false, nullable: false, ColumnCategory.Unknown),
            },
            unreal: true,
            tupleDefinitionName: TupleDefinitions.WixMediaTemplate.Name,
            tupleIdIsPrimaryKey: false
        );

        public static readonly TableDefinition WixMerge = new TableDefinition(
            "WixMerge",
            new[]
            {
                new ColumnDefinition("WixMerge", ColumnType.String, 72, primaryKey: true, nullable: false, ColumnCategory.Unknown),
                new ColumnDefinition("Language", ColumnType.Number, 2, primaryKey: false, nullable: false, ColumnCategory.Unknown, forceLocalizable: true),
                new ColumnDefinition("Directory_", ColumnType.String, 72, primaryKey: false, nullable: true, ColumnCategory.Unknown),
                new ColumnDefinition("SourceFile", ColumnType.Object, 0, primaryKey: false, nullable: false, ColumnCategory.Unknown),
                new ColumnDefinition("DiskId", ColumnType.Number, 2, primaryKey: false, nullable: false, ColumnCategory.Unknown),
                new ColumnDefinition("FileCompression", ColumnType.Number, 2, primaryKey: false, nullable: true, ColumnCategory.Unknown),
                new ColumnDefinition("ConfigurationData", ColumnType.String, 255, primaryKey: false, nullable: true, ColumnCategory.Unknown),
                new ColumnDefinition("Feature_", ColumnType.String, 72, primaryKey: false, nullable: false, ColumnCategory.Unknown),
            },
            unreal: true,
            tupleDefinitionName: TupleDefinitions.WixMerge.Name,
            tupleIdIsPrimaryKey: true
        );

        public static readonly TableDefinition WixOrdering = new TableDefinition(
            "WixOrdering",
            new[]
            {
                new ColumnDefinition("ItemType", ColumnType.String, 0, primaryKey: true, nullable: false, ColumnCategory.Unknown, description: "Primary key used to identify the item in another table."),
                new ColumnDefinition("ItemId_", ColumnType.String, 72, primaryKey: true, nullable: false, ColumnCategory.Identifier, description: "Reference to an entry in another table."),
                new ColumnDefinition("DependsOnType", ColumnType.String, 0, primaryKey: true, nullable: false, ColumnCategory.Unknown, description: "Primary key used to identify the item in another table."),
                new ColumnDefinition("DependsOnId_", ColumnType.String, 72, primaryKey: true, nullable: false, ColumnCategory.Identifier, description: "Reference to an entry in another table."),
            },
            unreal: true,
            tupleDefinitionName: TupleDefinitions.WixOrdering.Name,
            tupleIdIsPrimaryKey: false
        );

        public static readonly TableDefinition WixDeltaPatchFile = new TableDefinition(
            "WixDeltaPatchFile",
            new[]
            {
                new ColumnDefinition("File_", ColumnType.String, 72, primaryKey: true, nullable: false, ColumnCategory.Unknown, keyTable: "File", keyColumn: 1, modularizeType: ColumnModularizeType.Column),
                new ColumnDefinition("RetainLengths", ColumnType.Preserved, 0, primaryKey: false, nullable: true, ColumnCategory.Text),
                new ColumnDefinition("IgnoreOffsets", ColumnType.Preserved, 0, primaryKey: false, nullable: true, ColumnCategory.Text),
                new ColumnDefinition("IgnoreLengths", ColumnType.Preserved, 0, primaryKey: false, nullable: true, ColumnCategory.Text),
                new ColumnDefinition("RetainOffsets", ColumnType.Preserved, 0, primaryKey: false, nullable: true, ColumnCategory.Text),
                new ColumnDefinition("SymbolPaths", ColumnType.Preserved, 0, primaryKey: false, nullable: true, ColumnCategory.Text),
            },
            unreal: true,
            tupleDefinitionName: TupleDefinitions.WixDeltaPatchFile.Name,
            tupleIdIsPrimaryKey: false
        );

        public static readonly TableDefinition WixDeltaPatchSymbolPaths = new TableDefinition(
            "WixDeltaPatchSymbolPaths",
            new[]
            {
                new ColumnDefinition("Id", ColumnType.String, 72, primaryKey: true, nullable: false, ColumnCategory.Unknown),
                new ColumnDefinition("Type", ColumnType.Number, 2, primaryKey: true, nullable: false, ColumnCategory.Unknown, minValue: 0, maxValue: 4),
                new ColumnDefinition("SymbolPaths", ColumnType.Preserved, 0, primaryKey: false, nullable: false, ColumnCategory.Text),
            },
            unreal: true,
            tupleDefinitionName: TupleDefinitions.WixDeltaPatchSymbolPaths.Name,
            tupleIdIsPrimaryKey: false
        );

        public static readonly TableDefinition WixProperty = new TableDefinition(
            "WixProperty",
            new[]
            {
                new ColumnDefinition("Property_", ColumnType.String, 72, primaryKey: false, nullable: false, ColumnCategory.Unknown, modularizeType: ColumnModularizeType.Column),
                new ColumnDefinition("Attributes", ColumnType.Number, 4, primaryKey: false, nullable: false, ColumnCategory.Unknown),
            },
            unreal: true,
            tupleDefinitionName: TupleDefinitions.WixProperty.Name,
            tupleIdIsPrimaryKey: false
        );

        public static readonly TableDefinition WixSimpleReference = new TableDefinition(
            "WixSimpleReference",
            new[]
            {
                new ColumnDefinition("Table", ColumnType.String, 32, primaryKey: false, nullable: false, ColumnCategory.Unknown),
                new ColumnDefinition("PrimaryKeys", ColumnType.String, 0, primaryKey: false, nullable: false, ColumnCategory.Unknown),
            },
            unreal: true,
            tupleDefinitionName: TupleDefinitions.WixSimpleReference.Name,
            tupleIdIsPrimaryKey: false
        );

        public static readonly TableDefinition WixSuppressAction = new TableDefinition(
            "WixSuppressAction",
            new[]
            {
                new ColumnDefinition("SequenceTable", ColumnType.String, 72, primaryKey: true, nullable: false, ColumnCategory.Unknown),
                new ColumnDefinition("Action", ColumnType.String, 72, primaryKey: true, nullable: false, ColumnCategory.Unknown),
            },
            unreal: true,
            tupleDefinitionName: TupleDefinitions.WixSuppressAction.Name,
            tupleIdIsPrimaryKey: false
        );

        public static readonly TableDefinition WixSuppressModularization = new TableDefinition(
            "WixSuppressModularization",
            new[]
            {
                new ColumnDefinition("WixSuppressModularization", ColumnType.String, 72, primaryKey: false, nullable: false, ColumnCategory.Unknown),
            },
            unreal: true,
            tupleDefinitionName: TupleDefinitions.WixSuppressModularization.Name,
            tupleIdIsPrimaryKey: true
        );

        public static readonly TableDefinition WixPatchBaseline = new TableDefinition(
            "WixPatchBaseline",
            new[]
            {
                new ColumnDefinition("WixPatchBaseline", ColumnType.String, 72, primaryKey: true, nullable: false, ColumnCategory.Identifier, description: "Primary key used to identify sets of transforms in a patch."),
                new ColumnDefinition("DiskId", ColumnType.Number, 2, primaryKey: false, nullable: false, ColumnCategory.Unknown),
                new ColumnDefinition("ValidationFlags", ColumnType.Number, 4, primaryKey: false, nullable: false, ColumnCategory.Integer, description: "Patch transform validation flags for the associated patch baseline."),
            },
            unreal: true,
            tupleDefinitionName: TupleDefinitions.WixPatchBaseline.Name,
            tupleIdIsPrimaryKey: true
        );

        public static readonly TableDefinition WixPatchRef = new TableDefinition(
            "WixPatchRef",
            new[]
            {
                new ColumnDefinition("Table", ColumnType.String, 32, primaryKey: false, nullable: false, ColumnCategory.Unknown),
                new ColumnDefinition("PrimaryKeys", ColumnType.String, 0, primaryKey: false, nullable: false, ColumnCategory.Unknown),
            },
            unreal: true,
            tupleDefinitionName: TupleDefinitions.WixPatchRef.Name,
            tupleIdIsPrimaryKey: false
        );

        public static readonly TableDefinition WixPatchId = new TableDefinition(
            "WixPatchId",
            new[]
            {
                new ColumnDefinition("ProductCode", ColumnType.String, 38, primaryKey: false, nullable: false, ColumnCategory.Unknown),
                new ColumnDefinition("ClientPatchId", ColumnType.String, 72, primaryKey: false, nullable: false, ColumnCategory.Unknown),
                new ColumnDefinition("OptimizePatchSizeForLargeFiles", ColumnType.Number, 2, primaryKey: false, nullable: true, ColumnCategory.Unknown, minValue: 0, maxValue: 1),
                new ColumnDefinition("ApiPatchingSymbolFlags", ColumnType.Number, 4, primaryKey: false, nullable: true, ColumnCategory.Unknown, minValue: 0, maxValue: 7),
            },
            unreal: true,
            tupleDefinitionName: TupleDefinitions.WixPatchId.Name,
            tupleIdIsPrimaryKey: true
        );

        public static readonly TableDefinition WixPatchTarget = new TableDefinition(
            "WixPatchTarget",
            new[]
            {
                new ColumnDefinition("ProductCode", ColumnType.String, 38, primaryKey: false, nullable: false, ColumnCategory.Unknown),
            },
            unreal: true,
            tupleDefinitionName: TupleDefinitions.WixPatchTarget.Name,
            tupleIdIsPrimaryKey: false
        );

        public static readonly TableDefinition WixPatchMetadata = new TableDefinition(
            "WixPatchMetadata",
            new[]
            {
                new ColumnDefinition("Property", ColumnType.String, 72, primaryKey: true, nullable: false, ColumnCategory.Unknown),
                new ColumnDefinition("Value", ColumnType.Localized, 0, primaryKey: false, nullable: false, ColumnCategory.Unknown),
            },
            unreal: true,
            tupleIdIsPrimaryKey: false
        );

        public static readonly TableDefinition WixUI = new TableDefinition(
            "WixUI",
            new[]
            {
                new ColumnDefinition("WixUI", ColumnType.String, 0, primaryKey: true, nullable: false, ColumnCategory.Unknown),
            },
            unreal: true,
            tupleDefinitionName: TupleDefinitions.WixUI.Name,
            tupleIdIsPrimaryKey: true
        );

        public static readonly TableDefinition WixVariable = new TableDefinition(
            "WixVariable",
            new[]
            {
                new ColumnDefinition("WixVariable", ColumnType.String, 0, primaryKey: false, nullable: false, ColumnCategory.Unknown),
                new ColumnDefinition("Value", ColumnType.Localized, 0, primaryKey: false, nullable: true, ColumnCategory.Unknown),
                new ColumnDefinition("Attributes", ColumnType.Number, 4, primaryKey: false, nullable: false, ColumnCategory.Unknown),
            },
            unreal: true,
            tupleDefinitionName: TupleDefinitions.WixVariable.Name,
            tupleIdIsPrimaryKey: true
        );

        public static readonly TableDefinition WixBundleContainer = new TableDefinition(
            "WixBundleContainer",
            new[]
            {
                new ColumnDefinition("WixBundleContainer", ColumnType.String, 0, primaryKey: true, nullable: false, ColumnCategory.Identifier),
                new ColumnDefinition("Name", ColumnType.String, 0, primaryKey: false, nullable: false, ColumnCategory.Unknown),
                new ColumnDefinition("Type", ColumnType.Number, 2, primaryKey: false, nullable: false, ColumnCategory.Unknown, minValue: 0, maxValue: 1),
                new ColumnDefinition("DownloadUrl", ColumnType.String, 0, primaryKey: false, nullable: true, ColumnCategory.Unknown),
                new ColumnDefinition("Size", ColumnType.Number, 4, primaryKey: false, nullable: true, ColumnCategory.Unknown, minValue: 0),
                new ColumnDefinition("Hash", ColumnType.String, 0, primaryKey: false, nullable: true, ColumnCategory.Unknown),
                new ColumnDefinition("AttachedContainerIndex", ColumnType.Number, 2, primaryKey: false, nullable: true, ColumnCategory.Unknown),
                new ColumnDefinition("WorkingPath", ColumnType.String, 0, primaryKey: false, nullable: true, ColumnCategory.Unknown),
            },
            unreal: true,
            tupleDefinitionName: TupleDefinitions.WixBundleContainer.Name,
            tupleIdIsPrimaryKey: true
        );

        public static readonly TableDefinition WixBundlePayloadGroup = new TableDefinition(
            "WixBundlePayloadGroup",
            new[]
            {
                new ColumnDefinition("WixBundlePayloadGroup", ColumnType.String, 0, primaryKey: true, nullable: false, ColumnCategory.Identifier),
            },
            unreal: true,
            tupleDefinitionName: TupleDefinitions.WixBundlePayloadGroup.Name,
            tupleIdIsPrimaryKey: true
        );

        public static readonly TableDefinition WixBundlePayload = new TableDefinition(
            "WixBundlePayload",
            new[]
            {
                new ColumnDefinition("WixBundlePayload", ColumnType.String, 0, primaryKey: true, nullable: false, ColumnCategory.Identifier),
                new ColumnDefinition("Name", ColumnType.String, 0, primaryKey: false, nullable: true, ColumnCategory.Unknown),
                new ColumnDefinition("SourceFile", ColumnType.Object, 0, primaryKey: false, nullable: true, ColumnCategory.Unknown),
                new ColumnDefinition("DownloadUrl", ColumnType.String, 0, primaryKey: false, nullable: true, ColumnCategory.Unknown),
                new ColumnDefinition("Compressed", ColumnType.Number, 2, primaryKey: false, nullable: false, ColumnCategory.Unknown, minValue: 0, maxValue: 2),
                new ColumnDefinition("UnresolvedSourceFile", ColumnType.String, 0, primaryKey: false, nullable: true, ColumnCategory.Unknown),
                new ColumnDefinition("DisplayName", ColumnType.String, 0, primaryKey: false, nullable: true, ColumnCategory.Unknown),
                new ColumnDefinition("Description", ColumnType.String, 0, primaryKey: false, nullable: true, ColumnCategory.Unknown),
                new ColumnDefinition("EnableSignatureValidation", ColumnType.Number, 2, primaryKey: false, nullable: true, ColumnCategory.Unknown, minValue: 0, maxValue: 1),
                new ColumnDefinition("FileSize", ColumnType.Number, 4, primaryKey: false, nullable: true, ColumnCategory.Unknown, minValue: 0, maxValue: 2147483647),
                new ColumnDefinition("Version", ColumnType.String, 24, primaryKey: false, nullable: true, ColumnCategory.Unknown),
                new ColumnDefinition("Hash", ColumnType.String, 0, primaryKey: false, nullable: true, ColumnCategory.Unknown),
                new ColumnDefinition("PublicKey", ColumnType.String, 0, primaryKey: false, nullable: true, ColumnCategory.Unknown),
                new ColumnDefinition("Thumbprint", ColumnType.String, 0, primaryKey: false, nullable: true, ColumnCategory.Unknown),
                new ColumnDefinition("Catalog_", ColumnType.String, 0, primaryKey: false, nullable: true, ColumnCategory.Identifier, keyTable: "WixBundleCatalog", keyColumn: 1, description: "Reference to a catalog entry in the WixBundleCatalog table."),
                new ColumnDefinition("Container_", ColumnType.String, 0, primaryKey: false, nullable: true, ColumnCategory.Unknown, keyTable: "WixBundleContainer", keyColumn: 1, description: "Reference to a container entry in the WixBundleContainer table."),
                new ColumnDefinition("Package", ColumnType.String, 0, primaryKey: false, nullable: true, ColumnCategory.Unknown),
                new ColumnDefinition("ContentFile", ColumnType.Number, 2, primaryKey: false, nullable: true, ColumnCategory.Unknown, minValue: 0, maxValue: 1),
                new ColumnDefinition("EmbeddedId", ColumnType.String, 0, primaryKey: false, nullable: true, ColumnCategory.Unknown),
                new ColumnDefinition("LayoutOnly", ColumnType.Number, 2, primaryKey: false, nullable: true, ColumnCategory.Unknown, minValue: 0, maxValue: 1),
                new ColumnDefinition("Packaging", ColumnType.Number, 2, primaryKey: false, nullable: true, ColumnCategory.Unknown, minValue: 1, maxValue: 2),
                new ColumnDefinition("ParentPackagePayload_", ColumnType.String, 0, primaryKey: false, nullable: true, ColumnCategory.Unknown),
            },
            unreal: true,
            tupleDefinitionName: TupleDefinitions.WixBundlePayload.Name,
            tupleIdIsPrimaryKey: true
        );

        public static readonly TableDefinition WixBundlePatchTargetCode = new TableDefinition(
            "WixBundlePatchTargetCode",
            new[]
            {
                new ColumnDefinition("PackageId", ColumnType.String, 0, primaryKey: true, nullable: false, ColumnCategory.Identifier),
                new ColumnDefinition("TargetCode", ColumnType.String, 0, primaryKey: true, nullable: true, ColumnCategory.Unknown),
                new ColumnDefinition("Attributes", ColumnType.Number, 4, primaryKey: false, nullable: true, ColumnCategory.Unknown, minValue: 0, maxValue: 2147483647),
            },
            unreal: true,
            tupleDefinitionName: TupleDefinitions.WixBundlePatchTargetCode.Name,
            tupleIdIsPrimaryKey: false
        );

        public static readonly TableDefinition WixBundle = new TableDefinition(
            "WixBundle",
            new[]
            {
                new ColumnDefinition("Version", ColumnType.String, 24, primaryKey: false, nullable: false, ColumnCategory.Unknown),
                new ColumnDefinition("Copyright", ColumnType.String, 0, primaryKey: false, nullable: true, ColumnCategory.Unknown),
                new ColumnDefinition("Name", ColumnType.String, 0, primaryKey: false, nullable: true, ColumnCategory.Unknown),
                new ColumnDefinition("AboutUrl", ColumnType.String, 0, primaryKey: false, nullable: true, ColumnCategory.Unknown),
                new ColumnDefinition("DisableModify", ColumnType.Number, 2, primaryKey: false, nullable: true, ColumnCategory.Unknown, minValue: 0, maxValue: 2),
                new ColumnDefinition("DisableRemove", ColumnType.Number, 2, primaryKey: false, nullable: true, ColumnCategory.Unknown, minValue: 0, maxValue: 1),
                new ColumnDefinition("DisableRepair", ColumnType.Number, 2, primaryKey: false, nullable: true, ColumnCategory.Unknown, minValue: 0, maxValue: 1),
                new ColumnDefinition("HelpTelephone", ColumnType.String, 0, primaryKey: false, nullable: true, ColumnCategory.Unknown),
                new ColumnDefinition("HelpUrl", ColumnType.String, 0, primaryKey: false, nullable: true, ColumnCategory.Unknown),
                new ColumnDefinition("Manufacturer", ColumnType.String, 0, primaryKey: false, nullable: true, ColumnCategory.Unknown),
                new ColumnDefinition("UpdateUrl", ColumnType.String, 0, primaryKey: false, nullable: true, ColumnCategory.Unknown),
                new ColumnDefinition("Compressed", ColumnType.Number, 2, primaryKey: false, nullable: true, ColumnCategory.Unknown, minValue: 0, maxValue: 1),
                new ColumnDefinition("LogPrefixAndExtension", ColumnType.String, 0, primaryKey: false, nullable: true, ColumnCategory.Unknown),
                new ColumnDefinition("IconSourceFile", ColumnType.Object, 0, primaryKey: false, nullable: true, ColumnCategory.Unknown),
                new ColumnDefinition("SplashScreenSourceFile", ColumnType.Object, 0, primaryKey: false, nullable: true, ColumnCategory.Unknown),
                new ColumnDefinition("Condition", ColumnType.String, 0, primaryKey: false, nullable: true, ColumnCategory.Unknown),
                new ColumnDefinition("Tag", ColumnType.String, 0, primaryKey: false, nullable: true, ColumnCategory.Unknown),
                new ColumnDefinition("Platform", ColumnType.String, 4, primaryKey: false, nullable: false, ColumnCategory.Unknown),
                new ColumnDefinition("ParentName", ColumnType.String, 0, primaryKey: false, nullable: true, ColumnCategory.Unknown),
                new ColumnDefinition("UpgradeCode", ColumnType.String, 38, primaryKey: false, nullable: false, ColumnCategory.Guid),
                new ColumnDefinition("BundleId", ColumnType.String, 38, primaryKey: false, nullable: false, ColumnCategory.Guid, description: "Only valid after binding."),
                new ColumnDefinition("ProviderKey", ColumnType.String, 38, primaryKey: false, nullable: true, ColumnCategory.Guid, description: "Only valid after binding."),
                new ColumnDefinition("PerMachine", ColumnType.Number, 2, primaryKey: false, nullable: true, ColumnCategory.Unknown, minValue: 0, maxValue: 1, description: "Only valid after binding."),
            },
            unreal: true,
            tupleDefinitionName: TupleDefinitions.WixBundle.Name,
            tupleIdIsPrimaryKey: false
        );

        public static readonly TableDefinition WixApprovedExeForElevation = new TableDefinition(
            "WixApprovedExeForElevation",
            new[]
            {
                new ColumnDefinition("Id", ColumnType.String, 0, primaryKey: true, nullable: false, ColumnCategory.Identifier),
                new ColumnDefinition("Key", ColumnType.String, 0, primaryKey: false, nullable: false, ColumnCategory.Unknown),
                new ColumnDefinition("Value", ColumnType.String, 0, primaryKey: false, nullable: true, ColumnCategory.Unknown),
                new ColumnDefinition("Attributes", ColumnType.Number, 4, primaryKey: false, nullable: false, ColumnCategory.Unknown, minValue: 0, maxValue: 1),
            },
            unreal: true,
            tupleDefinitionName: TupleDefinitions.WixApprovedExeForElevation.Name,
            tupleIdIsPrimaryKey: true
        );

        public static readonly TableDefinition WixBundleUpdate = new TableDefinition(
            "WixBundleUpdate",
            new[]
            {
                new ColumnDefinition("Location", ColumnType.String, 0, primaryKey: false, nullable: false, ColumnCategory.Unknown),
                new ColumnDefinition("Attributes", ColumnType.Number, 4, primaryKey: false, nullable: true, ColumnCategory.Unknown),
            },
            unreal: true,
            tupleDefinitionName: TupleDefinitions.WixBundleUpdate.Name,
            tupleIdIsPrimaryKey: false
        );

        public static readonly TableDefinition WixBootstrapperApplication = new TableDefinition(
            "WixBootstrapperApplication",
            new[]
            {
                new ColumnDefinition("Id", ColumnType.String, 0, primaryKey: true, nullable: false, ColumnCategory.Identifier),
            },
            unreal: true,
            tupleDefinitionName: TupleDefinitions.WixBootstrapperApplication.Name,
            tupleIdIsPrimaryKey: true
        );

        public static readonly TableDefinition WixUpdateRegistration = new TableDefinition(
            "WixUpdateRegistration",
            new[]
            {
                new ColumnDefinition("Manufacturer", ColumnType.String, 0, primaryKey: false, nullable: false, ColumnCategory.Unknown),
                new ColumnDefinition("Department", ColumnType.String, 0, primaryKey: false, nullable: true, ColumnCategory.Unknown),
                new ColumnDefinition("ProductFamily", ColumnType.String, 0, primaryKey: false, nullable: true, ColumnCategory.Unknown),
                new ColumnDefinition("Name", ColumnType.String, 0, primaryKey: false, nullable: false, ColumnCategory.Unknown),
                new ColumnDefinition("Classification", ColumnType.String, 0, primaryKey: false, nullable: false, ColumnCategory.Unknown),
            },
            unreal: true,
            tupleDefinitionName: TupleDefinitions.WixUpdateRegistration.Name,
            tupleIdIsPrimaryKey: false
        );

        public static readonly TableDefinition WixBundleCatalog = new TableDefinition(
            "WixBundleCatalog",
            new[]
            {
                new ColumnDefinition("WixBundleCatalog", ColumnType.String, 0, primaryKey: true, nullable: false, ColumnCategory.Identifier),
                new ColumnDefinition("Payload_", ColumnType.String, 0, primaryKey: false, nullable: false, ColumnCategory.Identifier, keyTable: "WixBundlePayload", keyColumn: 1, description: "Reference to a payload entry in the WixBundlePayload table."),
            },
            unreal: true,
            tupleDefinitionName: TupleDefinitions.WixBundleCatalog.Name,
            tupleIdIsPrimaryKey: true
        );

        public static readonly TableDefinition WixChain = new TableDefinition(
            "WixChain",
            new[]
            {
                new ColumnDefinition("Attributes", ColumnType.Number, 4, primaryKey: false, nullable: false, ColumnCategory.Unknown, minValue: 0, maxValue: 2147483647, description: "A 32-bit word that specifies the attribute flags to be applied to the chain."),
            },
            unreal: true,
            tupleDefinitionName: TupleDefinitions.WixChain.Name,
            tupleIdIsPrimaryKey: false
        );

        public static readonly TableDefinition WixChainItem = new TableDefinition(
            "WixChainItem",
            new[]
            {
                new ColumnDefinition("Id", ColumnType.String, 0, primaryKey: true, nullable: false, ColumnCategory.Identifier),
            },
            unreal: true,
            tupleDefinitionName: TupleDefinitions.WixChainItem.Name,
            tupleIdIsPrimaryKey: true
        );

        public static readonly TableDefinition WixBundleRollbackBoundary = new TableDefinition(
            "WixBundleRollbackBoundary",
            new[]
            {
                new ColumnDefinition("WixChainItem_", ColumnType.String, 0, primaryKey: true, nullable: false, ColumnCategory.Identifier, keyTable: "WixChainItem", keyColumn: 1, description: "Reference to a WixChainItem entry in the WixChainItem table."),
                new ColumnDefinition("Vital", ColumnType.Number, 2, primaryKey: false, nullable: true, ColumnCategory.Unknown, minValue: 0, maxValue: 1),
                new ColumnDefinition("Transaction", ColumnType.Number, 2, primaryKey: false, nullable: true, ColumnCategory.Unknown, minValue: 0, maxValue: 1),
            },
            unreal: true,
            tupleDefinitionName: TupleDefinitions.WixBundleRollbackBoundary.Name,
            tupleIdIsPrimaryKey: true
        );

        public static readonly TableDefinition WixBundlePackageGroup = new TableDefinition(
            "WixBundlePackageGroup",
            new[]
            {
                new ColumnDefinition("WixBundlePackageGroup", ColumnType.String, 0, primaryKey: true, nullable: false, ColumnCategory.Identifier),
            },
            unreal: true,
            tupleDefinitionName: TupleDefinitions.WixBundlePackageGroup.Name,
            tupleIdIsPrimaryKey: true
        );

        public static readonly TableDefinition WixBundlePackage = new TableDefinition(
            "WixBundlePackage",
            new[]
            {
                new ColumnDefinition("WixChainItem_", ColumnType.String, 0, primaryKey: true, nullable: false, ColumnCategory.Identifier, keyTable: "WixChainItem", keyColumn: 1, description: "Reference to a WixChainItem entry in the WixChainItem table."),
                new ColumnDefinition("Type", ColumnType.Number, 2, primaryKey: false, nullable: false, ColumnCategory.Unknown, minValue: 0, maxValue: 3),
                new ColumnDefinition("Payload_", ColumnType.String, 0, primaryKey: false, nullable: false, ColumnCategory.Identifier, keyTable: "WixBundlePayload", keyColumn: 1, description: "Reference to a payload entry in the WixBundlePayload table."),
                new ColumnDefinition("Attributes", ColumnType.Number, 4, primaryKey: false, nullable: false, ColumnCategory.Unknown, minValue: 0, maxValue: 2147483647, description: "A 32-bit word that specifies the attribute flags to be applied to this package."),
                new ColumnDefinition("InstallCondition", ColumnType.String, 0, primaryKey: false, nullable: true, ColumnCategory.Unknown),
                new ColumnDefinition("Cache", ColumnType.Number, 2, primaryKey: false, nullable: true, ColumnCategory.Unknown, minValue: 0, maxValue: 2),
                new ColumnDefinition("CacheId", ColumnType.String, 0, primaryKey: false, nullable: true, ColumnCategory.Unknown),
                new ColumnDefinition("Vital", ColumnType.Number, 2, primaryKey: false, nullable: true, ColumnCategory.Unknown, minValue: 0, maxValue: 1),
                new ColumnDefinition("PerMachine", ColumnType.Number, 2, primaryKey: false, nullable: true, ColumnCategory.Unknown, minValue: 0, maxValue: 2),
                new ColumnDefinition("LogPathVariable", ColumnType.String, 0, primaryKey: false, nullable: true, ColumnCategory.Unknown),
                new ColumnDefinition("RollbackLogPathVariable", ColumnType.String, 0, primaryKey: false, nullable: true, ColumnCategory.Unknown),
                new ColumnDefinition("Size", ColumnType.Number, 4, primaryKey: false, nullable: false, ColumnCategory.Unknown),
                new ColumnDefinition("InstallSize", ColumnType.Number, 4, primaryKey: false, nullable: false, ColumnCategory.Unknown),
                new ColumnDefinition("Version", ColumnType.String, 24, primaryKey: false, nullable: true, ColumnCategory.Version),
                new ColumnDefinition("Language", ColumnType.Number, 2, primaryKey: false, nullable: true, ColumnCategory.Unknown),
                new ColumnDefinition("DisplayName", ColumnType.String, 0, primaryKey: false, nullable: true, ColumnCategory.Unknown),
                new ColumnDefinition("Description", ColumnType.String, 0, primaryKey: false, nullable: true, ColumnCategory.Unknown),
                new ColumnDefinition("RollbackBoundary_", ColumnType.String, 0, primaryKey: false, nullable: true, ColumnCategory.Unknown, keyTable: "WixBundleRollbackBoundary", keyColumn: 1, description: "Reference to a rollback boundary entry in the WixBundleRollbackBoundary table."),
                new ColumnDefinition("RollbackBoundaryBackward_", ColumnType.String, 0, primaryKey: false, nullable: true, ColumnCategory.Unknown, keyTable: "WixBundleRollbackBoundary", keyColumn: 1, description: "Reference to a rollback boundary entry in the WixBundleRollbackBoundary table."),
                new ColumnDefinition("x64", ColumnType.Number, 2, primaryKey: false, nullable: true, ColumnCategory.Unknown, minValue: 0, maxValue: 1),
            },
            unreal: true,
            tupleDefinitionName: TupleDefinitions.WixBundlePackage.Name,
            tupleIdIsPrimaryKey: true
        );

        public static readonly TableDefinition WixBundleExePackage = new TableDefinition(
            "WixBundleExePackage",
            new[]
            {
                new ColumnDefinition("WixBundlePackage_", ColumnType.String, 0, primaryKey: true, nullable: false, ColumnCategory.Identifier, keyTable: "WixBundlePackage", keyColumn: 1, description: "Reference to a chain package entry in the WixBundlePackage table."),
                new ColumnDefinition("Attributes", ColumnType.Number, 4, primaryKey: false, nullable: false, ColumnCategory.Unknown, minValue: 0, maxValue: 2147483647, description: "A 32-bit word that specifies the attribute flags to be applied to this MSI package."),
                new ColumnDefinition("DetectCondition", ColumnType.String, 0, primaryKey: false, nullable: true, ColumnCategory.Unknown),
                new ColumnDefinition("InstallCommand", ColumnType.String, 0, primaryKey: false, nullable: true, ColumnCategory.Unknown),
                new ColumnDefinition("RepairCommand", ColumnType.String, 0, primaryKey: false, nullable: true, ColumnCategory.Unknown),
                new ColumnDefinition("UninstallCommand", ColumnType.String, 0, primaryKey: false, nullable: true, ColumnCategory.Unknown),
                new ColumnDefinition("ExeProtocol", ColumnType.String, 0, primaryKey: false, nullable: true, ColumnCategory.Unknown),
            },
            unreal: true,
            tupleDefinitionName: TupleDefinitions.WixBundleExePackage.Name,
            tupleIdIsPrimaryKey: true
        );

        public static readonly TableDefinition WixBundleMsiPackage = new TableDefinition(
            "WixBundleMsiPackage",
            new[]
            {
                new ColumnDefinition("WixBundlePackage_", ColumnType.String, 0, primaryKey: true, nullable: false, ColumnCategory.Identifier, keyTable: "WixBundlePackage", keyColumn: 1, description: "Reference to a chain package entry in the WixBundlePackage table."),
                new ColumnDefinition("Attributes", ColumnType.Number, 4, primaryKey: false, nullable: false, ColumnCategory.Unknown, minValue: 0, maxValue: 2147483647, description: "A 32-bit word that specifies the attribute flags to be applied to this MSI package."),
                new ColumnDefinition("ProductCode", ColumnType.String, 38, primaryKey: false, nullable: false, ColumnCategory.Guid),
                new ColumnDefinition("UpgradeCode", ColumnType.String, 38, primaryKey: false, nullable: true, ColumnCategory.Guid),
                new ColumnDefinition("ProductVersion", ColumnType.String, 20, primaryKey: false, nullable: false, ColumnCategory.Unknown),
                new ColumnDefinition("ProductLanguage", ColumnType.Number, 2, primaryKey: false, nullable: false, ColumnCategory.Unknown),
                new ColumnDefinition("ProductName", ColumnType.String, 0, primaryKey: false, nullable: false, ColumnCategory.Unknown),
                new ColumnDefinition("Manufacturer", ColumnType.String, 0, primaryKey: false, nullable: true, ColumnCategory.Unknown),
            },
            unreal: true,
            tupleDefinitionName: TupleDefinitions.WixBundleMsiPackage.Name,
            tupleIdIsPrimaryKey: true
        );

        public static readonly TableDefinition WixBundleMspPackage = new TableDefinition(
            "WixBundleMspPackage",
            new[]
            {
                new ColumnDefinition("WixBundlePackage_", ColumnType.String, 0, primaryKey: true, nullable: false, ColumnCategory.Identifier, keyTable: "WixBundlePackage", keyColumn: 1, description: "Reference to a chain package entry in the WixBundlePackage table."),
                new ColumnDefinition("Attributes", ColumnType.Number, 2, primaryKey: false, nullable: true, ColumnCategory.Unknown, minValue: 0, maxValue: 1),
                new ColumnDefinition("PatchCode", ColumnType.String, 38, primaryKey: false, nullable: true, ColumnCategory.Guid),
                new ColumnDefinition("Manufacturer", ColumnType.String, 0, primaryKey: false, nullable: true, ColumnCategory.Unknown),
                new ColumnDefinition("PatchXml", ColumnType.String, 0, primaryKey: false, nullable: true, ColumnCategory.Unknown),
            },
            unreal: true,
            tupleDefinitionName: TupleDefinitions.WixBundleMspPackage.Name,
            tupleIdIsPrimaryKey: true
        );

        public static readonly TableDefinition WixBundleMsuPackage = new TableDefinition(
            "WixBundleMsuPackage",
            new[]
            {
                new ColumnDefinition("WixBundlePackage_", ColumnType.String, 0, primaryKey: true, nullable: false, ColumnCategory.Identifier, keyTable: "WixBundlePackage", keyColumn: 1, description: "Reference to a chain package entry in the WixBundlePackage table."),
                new ColumnDefinition("DetectCondition", ColumnType.String, 0, primaryKey: false, nullable: true, ColumnCategory.Unknown),
                new ColumnDefinition("MsuKB", ColumnType.String, 0, primaryKey: false, nullable: true, ColumnCategory.Unknown),
            },
            unreal: true,
            tupleDefinitionName: TupleDefinitions.WixBundleMsuPackage.Name,
            tupleIdIsPrimaryKey: true
        );

        public static readonly TableDefinition WixBundlePackageExitCode = new TableDefinition(
            "WixBundlePackageExitCode",
            new[]
            {
                new ColumnDefinition("WixBundlePackage_", ColumnType.String, 0, primaryKey: true, nullable: false, ColumnCategory.Identifier, keyTable: "WixBundlePackage", keyColumn: 1, description: "Reference to a chain package entry in the WixBundlePackage table for the parent Exe."),
                new ColumnDefinition("Code", ColumnType.Number, 0, primaryKey: true, nullable: true, ColumnCategory.Integer),
                new ColumnDefinition("Behavior", ColumnType.Number, 2, primaryKey: false, nullable: false, ColumnCategory.Integer, minValue: 0, maxValue: 3),
            },
            unreal: true,
            tupleDefinitionName: TupleDefinitions.WixBundlePackageExitCode.Name,
            tupleIdIsPrimaryKey: false
        );

        public static readonly TableDefinition WixBundleMsiFeature = new TableDefinition(
            "WixBundleMsiFeature",
            new[]
            {
                new ColumnDefinition("WixBundlePackage_", ColumnType.String, 0, primaryKey: true, nullable: false, ColumnCategory.Identifier, keyTable: "WixBundlePackage", keyColumn: 1, description: "Reference to a chain package entry in the WixBundlePackage table."),
                new ColumnDefinition("Name", ColumnType.String, 0, primaryKey: true, nullable: false, ColumnCategory.Identifier),
                new ColumnDefinition("Size", ColumnType.Number, 4, primaryKey: false, nullable: false, ColumnCategory.Unknown),
                new ColumnDefinition("Parent", ColumnType.String, 0, primaryKey: false, nullable: false, ColumnCategory.Unknown),
                new ColumnDefinition("Title", ColumnType.String, 0, primaryKey: false, nullable: false, ColumnCategory.Unknown),
                new ColumnDefinition("Description", ColumnType.String, 0, primaryKey: false, nullable: false, ColumnCategory.Unknown),
                new ColumnDefinition("Display", ColumnType.Number, 2, primaryKey: false, nullable: false, ColumnCategory.Unknown),
                new ColumnDefinition("Level", ColumnType.Number, 2, primaryKey: false, nullable: false, ColumnCategory.Unknown),
                new ColumnDefinition("Directory", ColumnType.String, 0, primaryKey: false, nullable: false, ColumnCategory.Unknown),
                new ColumnDefinition("Attributes", ColumnType.Number, 2, primaryKey: false, nullable: false, ColumnCategory.Unknown),
            },
            unreal: true,
            tupleDefinitionName: TupleDefinitions.WixBundleMsiFeature.Name,
            tupleIdIsPrimaryKey: false
        );

        public static readonly TableDefinition WixBundleMsiProperty = new TableDefinition(
            "WixBundleMsiProperty",
            new[]
            {
                new ColumnDefinition("WixBundlePackage_", ColumnType.String, 0, primaryKey: true, nullable: false, ColumnCategory.Identifier, keyTable: "WixBundlePackage", keyColumn: 1, description: "Reference to a chain package entry in the WixBundlePackage table."),
                new ColumnDefinition("Name", ColumnType.String, 0, primaryKey: true, nullable: false, ColumnCategory.Identifier),
                new ColumnDefinition("Value", ColumnType.String, 0, primaryKey: false, nullable: false, ColumnCategory.Unknown),
                new ColumnDefinition("Condition", ColumnType.String, 0, primaryKey: false, nullable: true, ColumnCategory.Unknown),
            },
            unreal: true,
            tupleDefinitionName: TupleDefinitions.WixBundleMsiProperty.Name,
            tupleIdIsPrimaryKey: false
        );

        public static readonly TableDefinition WixBundleSlipstreamMsp = new TableDefinition(
            "WixBundleSlipstreamMsp",
            new[]
            {
                new ColumnDefinition("WixBundlePackage_", ColumnType.String, 0, primaryKey: true, nullable: false, ColumnCategory.Identifier, keyTable: "WixBundlePackage", keyColumn: 1, description: "Reference to a chain package entry in the WixBundlePackage table for the parent Msi."),
                new ColumnDefinition("WixBundlePackage_Msp", ColumnType.String, 0, primaryKey: true, nullable: false, ColumnCategory.Identifier, keyTable: "WixBundlePackage", keyColumn: 1, description: "Reference to a chain package entry in the WixBundlePackage table for the referenced Msp."),
            },
            unreal: true,
            tupleDefinitionName: TupleDefinitions.WixBundleSlipstreamMsp.Name,
            tupleIdIsPrimaryKey: false
        );

        public static readonly TableDefinition WixBundlePackageCommandLine = new TableDefinition(
            "WixBundlePackageCommandLine",
            new[]
            {
                new ColumnDefinition("WixBundlePackage_", ColumnType.String, 0, primaryKey: true, nullable: false, ColumnCategory.Identifier, keyTable: "WixBundlePackage", keyColumn: 1, description: "Reference to a chain package entry in the WixBundlePackage table."),
                new ColumnDefinition("InstallArgument", ColumnType.String, 0, primaryKey: false, nullable: true, ColumnCategory.Unknown),
                new ColumnDefinition("UninstallArgument", ColumnType.String, 0, primaryKey: false, nullable: true, ColumnCategory.Unknown),
                new ColumnDefinition("RepairArgument", ColumnType.String, 0, primaryKey: false, nullable: true, ColumnCategory.Unknown),
                new ColumnDefinition("Condition", ColumnType.String, 0, primaryKey: false, nullable: true, ColumnCategory.Unknown),
            },
            unreal: true,
            tupleDefinitionName: TupleDefinitions.WixBundlePackageCommandLine.Name,
            tupleIdIsPrimaryKey: false
        );

        public static readonly TableDefinition WixRelatedBundle = new TableDefinition(
            "WixRelatedBundle",
            new[]
            {
                new ColumnDefinition("Id", ColumnType.String, 38, primaryKey: true, nullable: false, ColumnCategory.Guid),
                new ColumnDefinition("Action", ColumnType.Number, 4, primaryKey: false, nullable: false, ColumnCategory.Unknown),
            },
            unreal: true,
            tupleDefinitionName: TupleDefinitions.WixRelatedBundle.Name,
            tupleIdIsPrimaryKey: false
        );

        public static readonly TableDefinition WixBundleRelatedPackage = new TableDefinition(
            "WixBundleRelatedPackage",
            new[]
            {
                new ColumnDefinition("WixBundlePackage_", ColumnType.String, 0, primaryKey: true, nullable: false, ColumnCategory.Identifier, keyTable: "WixBundlePackage", keyColumn: 1, description: "Reference to a chain package entry in the WixBundlePackage table."),
                new ColumnDefinition("Id", ColumnType.String, 0, primaryKey: true, nullable: false, ColumnCategory.Identifier),
                new ColumnDefinition("MinVersion", ColumnType.String, 0, primaryKey: false, nullable: false, ColumnCategory.Unknown),
                new ColumnDefinition("MaxVersion", ColumnType.String, 0, primaryKey: false, nullable: false, ColumnCategory.Unknown),
                new ColumnDefinition("Languages", ColumnType.String, 0, primaryKey: false, nullable: false, ColumnCategory.Unknown),
                new ColumnDefinition("MinInclusive", ColumnType.Number, 2, primaryKey: false, nullable: false, ColumnCategory.Unknown, minValue: 0, maxValue: 1),
                new ColumnDefinition("MaxInclusive", ColumnType.Number, 2, primaryKey: false, nullable: false, ColumnCategory.Unknown, minValue: 0, maxValue: 1),
                new ColumnDefinition("LangInclusive", ColumnType.Number, 2, primaryKey: false, nullable: false, ColumnCategory.Unknown, minValue: 0, maxValue: 1),
                new ColumnDefinition("OnlyDetect", ColumnType.Number, 2, primaryKey: false, nullable: false, ColumnCategory.Unknown, minValue: 0, maxValue: 1),
            },
            unreal: true,
            tupleDefinitionName: TupleDefinitions.WixBundleRelatedPackage.Name,
            tupleIdIsPrimaryKey: false
        );

        public static readonly TableDefinition WixBundleVariable = new TableDefinition(
            "WixBundleVariable",
            new[]
            {
                new ColumnDefinition("WixBundleVariable", ColumnType.String, 0, primaryKey: true, nullable: false, ColumnCategory.Identifier),
                new ColumnDefinition("Value", ColumnType.String, 0, primaryKey: false, nullable: true, ColumnCategory.Unknown),
                new ColumnDefinition("Type", ColumnType.String, 0, primaryKey: false, nullable: true, ColumnCategory.Unknown),
                new ColumnDefinition("Hidden", ColumnType.Number, 2, primaryKey: false, nullable: false, ColumnCategory.Unknown, minValue: 0, maxValue: 1),
                new ColumnDefinition("Persisted", ColumnType.Number, 2, primaryKey: false, nullable: false, ColumnCategory.Unknown, minValue: 0, maxValue: 1),
            },
            unreal: true,
            tupleDefinitionName: TupleDefinitions.WixBundleVariable.Name,
            tupleIdIsPrimaryKey: true
        );

        public static readonly TableDefinition WixBundleProperties = new TableDefinition(
            "WixBundleProperties",
            new[]
            {
                new ColumnDefinition("DisplayName", ColumnType.String, 0, primaryKey: false, nullable: true, ColumnCategory.Unknown),
                new ColumnDefinition("LogPathVariable", ColumnType.String, 0, primaryKey: false, nullable: true, ColumnCategory.Unknown),
                new ColumnDefinition("Compressed", ColumnType.String, 0, primaryKey: false, nullable: true, ColumnCategory.Unknown),
                new ColumnDefinition("Id", ColumnType.String, 0, primaryKey: false, nullable: true, ColumnCategory.Unknown),
                new ColumnDefinition("UpgradeCode", ColumnType.String, 0, primaryKey: false, nullable: true, ColumnCategory.Unknown),
                new ColumnDefinition("PerMachine", ColumnType.String, 0, primaryKey: false, nullable: true, ColumnCategory.Unknown),
            },
            unreal: true,
            tupleIdIsPrimaryKey: false
        );

        public static readonly TableDefinition WixPackageFeatureInfo = new TableDefinition(
            "WixPackageFeatureInfo",
            new[]
            {
                new ColumnDefinition("Package", ColumnType.String, 0, primaryKey: false, nullable: false, ColumnCategory.Unknown),
                new ColumnDefinition("Feature", ColumnType.String, 0, primaryKey: false, nullable: false, ColumnCategory.Unknown),
                new ColumnDefinition("Size", ColumnType.String, 0, primaryKey: false, nullable: false, ColumnCategory.Unknown),
                new ColumnDefinition("Parent", ColumnType.String, 0, primaryKey: false, nullable: true, ColumnCategory.Unknown),
                new ColumnDefinition("Title", ColumnType.String, 0, primaryKey: false, nullable: true, ColumnCategory.Unknown),
                new ColumnDefinition("Description", ColumnType.String, 0, primaryKey: false, nullable: true, ColumnCategory.Unknown),
                new ColumnDefinition("Display", ColumnType.String, 0, primaryKey: false, nullable: true, ColumnCategory.Unknown),
                new ColumnDefinition("Level", ColumnType.String, 0, primaryKey: false, nullable: false, ColumnCategory.Unknown),
                new ColumnDefinition("Directory", ColumnType.String, 0, primaryKey: false, nullable: true, ColumnCategory.Unknown),
                new ColumnDefinition("Attributes", ColumnType.String, 0, primaryKey: false, nullable: false, ColumnCategory.Unknown),
            },
            unreal: true,
            tupleIdIsPrimaryKey: false
        );

        public static readonly TableDefinition WixPackageProperties = new TableDefinition(
            "WixPackageProperties",
            new[]
            {
                new ColumnDefinition("Package", ColumnType.String, 0, primaryKey: true, nullable: false, ColumnCategory.Identifier, keyTable: "WixBundlePackage", keyColumn: 1, description: "Reference to a chain package entry in the WixBundlePackage table."),
                new ColumnDefinition("Vital", ColumnType.String, 0, primaryKey: false, nullable: true, ColumnCategory.Unknown, minValue: 0, maxValue: 1),
                new ColumnDefinition("DisplayName", ColumnType.String, 0, primaryKey: false, nullable: true, ColumnCategory.Unknown),
                new ColumnDefinition("Description", ColumnType.String, 0, primaryKey: false, nullable: true, ColumnCategory.Unknown),
                new ColumnDefinition("DownloadSize", ColumnType.String, 0, primaryKey: false, nullable: true, ColumnCategory.Unknown),
                new ColumnDefinition("PackageSize", ColumnType.String, 0, primaryKey: false, nullable: true, ColumnCategory.Unknown),
                new ColumnDefinition("InstalledSize", ColumnType.String, 0, primaryKey: false, nullable: true, ColumnCategory.Unknown),
                new ColumnDefinition("PackageType", ColumnType.String, 0, primaryKey: false, nullable: false, ColumnCategory.Unknown),
                new ColumnDefinition("Permanent", ColumnType.String, 0, primaryKey: false, nullable: true, ColumnCategory.Unknown),
                new ColumnDefinition("LogPathVariable", ColumnType.String, 0, primaryKey: false, nullable: true, ColumnCategory.Unknown),
                new ColumnDefinition("RollbackLogPathVariable", ColumnType.String, 0, primaryKey: false, nullable: true, ColumnCategory.Unknown),
                new ColumnDefinition("Compressed", ColumnType.String, 0, primaryKey: false, nullable: true, ColumnCategory.Unknown),
                new ColumnDefinition("DisplayInternalUI", ColumnType.String, 0, primaryKey: false, nullable: true, ColumnCategory.Unknown),
                new ColumnDefinition("ProductCode", ColumnType.String, 0, primaryKey: false, nullable: true, ColumnCategory.Unknown),
                new ColumnDefinition("UpgradeCode", ColumnType.String, 0, primaryKey: false, nullable: true, ColumnCategory.Unknown),
                new ColumnDefinition("Version", ColumnType.String, 0, primaryKey: false, nullable: true, ColumnCategory.Unknown),
                new ColumnDefinition("InstallCondition", ColumnType.String, 0, primaryKey: false, nullable: true, ColumnCategory.Unknown),
                new ColumnDefinition("Cache", ColumnType.String, 0, primaryKey: false, nullable: true, ColumnCategory.Unknown, minValue: 0, maxValue: 2),
            },
            unreal: true,
            tupleIdIsPrimaryKey: true
        );

        public static readonly TableDefinition WixPayloadProperties = new TableDefinition(
            "WixPayloadProperties",
            new[]
            {
                new ColumnDefinition("Payload", ColumnType.String, 0, primaryKey: true, nullable: false, ColumnCategory.Identifier),
                new ColumnDefinition("Package", ColumnType.String, 0, primaryKey: true, nullable: true, ColumnCategory.Identifier, keyTable: "WixBundlePackage", keyColumn: 1, description: "Reference to a chain package entry in the WixBundlePackage table."),
                new ColumnDefinition("Container", ColumnType.String, 0, primaryKey: false, nullable: true, ColumnCategory.Unknown, keyTable: "WixBundleContainer", keyColumn: 1, description: "Reference to a container entry in the WixBundleContainer table."),
                new ColumnDefinition("Name", ColumnType.String, 0, primaryKey: false, nullable: false, ColumnCategory.Unknown),
                new ColumnDefinition("Size", ColumnType.String, 0, primaryKey: false, nullable: false, ColumnCategory.Unknown),
                new ColumnDefinition("DownloadUrl", ColumnType.String, 0, primaryKey: false, nullable: true, ColumnCategory.Unknown),
                new ColumnDefinition("LayoutOnly", ColumnType.String, 3, primaryKey: false, nullable: false, ColumnCategory.Unknown),
            },
            unreal: true,
            tupleIdIsPrimaryKey: false
        );

        public static readonly TableDefinition Streams = new TableDefinition(
            "_Streams",
            new[]
            {
                new ColumnDefinition("Name", ColumnType.String, 62, primaryKey: true, nullable: false, ColumnCategory.Unknown),
                new ColumnDefinition("Data", ColumnType.Object, 0, primaryKey: false, nullable: true, ColumnCategory.Unknown),
            },
            unreal: true,
            tupleIdIsPrimaryKey: false
        );

        public static readonly TableDefinition SummaryInformation = new TableDefinition(
            "_SummaryInformation",
            new[]
            {
                new ColumnDefinition("PropertyId", ColumnType.Number, 2, primaryKey: true, nullable: false, ColumnCategory.Unknown),
                new ColumnDefinition("Value", ColumnType.Localized, 255, primaryKey: false, nullable: false, ColumnCategory.Unknown),
            },
            tupleDefinitionName: TupleDefinitions.SummaryInformation.Name,
            tupleIdIsPrimaryKey: false
        );

        public static readonly TableDefinition TransformView = new TableDefinition(
            "_TransformView",
            new[]
            {
                new ColumnDefinition("Table", ColumnType.String, 0, primaryKey: true, nullable: false, ColumnCategory.Unknown),
                new ColumnDefinition("Column", ColumnType.String, 0, primaryKey: true, nullable: false, ColumnCategory.Unknown),
                new ColumnDefinition("Row", ColumnType.String, 0, primaryKey: false, nullable: false, ColumnCategory.Unknown),
                new ColumnDefinition("Data", ColumnType.String, 0, primaryKey: false, nullable: false, ColumnCategory.Unknown),
                new ColumnDefinition("Current", ColumnType.String, 0, primaryKey: false, nullable: false, ColumnCategory.Unknown),
            },
            unreal: true,
            tupleIdIsPrimaryKey: false
        );

        public static readonly TableDefinition Validation = new TableDefinition(
            "_Validation",
            new[]
            {
                new ColumnDefinition("Table", ColumnType.String, 32, primaryKey: true, nullable: false, ColumnCategory.Identifier, description: "Name of table"),
                new ColumnDefinition("Column", ColumnType.String, 32, primaryKey: true, nullable: false, ColumnCategory.Identifier, description: "Name of column"),
                new ColumnDefinition("Nullable", ColumnType.String, 4, primaryKey: false, nullable: false, ColumnCategory.Unknown, possibilities: "Y;N", description: "Whether the column is nullable"),
                new ColumnDefinition("MinValue", ColumnType.Number, 4, primaryKey: false, nullable: true, ColumnCategory.Unknown, minValue: -2147483647, maxValue: 2147483647, description: "Minimum value allowed"),
                new ColumnDefinition("MaxValue", ColumnType.Number, 4, primaryKey: false, nullable: true, ColumnCategory.Unknown, minValue: -2147483647, maxValue: 2147483647, description: "Maximum value allowed"),
                new ColumnDefinition("KeyTable", ColumnType.String, 255, primaryKey: false, nullable: true, ColumnCategory.Identifier, description: "For foreign key, Name of table to which data must link"),
                new ColumnDefinition("KeyColumn", ColumnType.Number, 2, primaryKey: false, nullable: true, ColumnCategory.Unknown, minValue: 1, maxValue: 32, description: "Column to which foreign key connects"),
                new ColumnDefinition("Category", ColumnType.String, 32, primaryKey: false, nullable: true, ColumnCategory.Unknown, possibilities: "Text;Formatted;Template;Condition;Guid;Path;Version;Language;Identifier;Binary;UpperCase;LowerCase;Filename;Paths;AnyPath;WildCardFilename;RegPath;CustomSource;Property;Cabinet;Shortcut;FormattedSDDLText;Integer;DoubleInteger;TimeDate;DefaultDir", description: "String category"),
                new ColumnDefinition("Set", ColumnType.String, 255, primaryKey: false, nullable: true, ColumnCategory.Text, description: "Set of values that are permitted"),
                new ColumnDefinition("Description", ColumnType.String, 255, primaryKey: false, nullable: true, ColumnCategory.Text, description: "Description of column"),
            },
            tupleIdIsPrimaryKey: false
        );

        public static readonly TableDefinition WixSearch = new TableDefinition(
            "WixSearch",
            new[]
            {
                new ColumnDefinition("WixSearch", ColumnType.String, 72, primaryKey: true, nullable: false, ColumnCategory.Identifier),
                new ColumnDefinition("Variable", ColumnType.String, 72, primaryKey: false, nullable: true, ColumnCategory.Identifier),
                new ColumnDefinition("Condition", ColumnType.String, 255, primaryKey: false, nullable: true, ColumnCategory.Condition),
            },
            unreal: true,
            tupleDefinitionName: TupleDefinitions.WixSearch.Name,
            tupleIdIsPrimaryKey: true
        );

        public static readonly TableDefinition WixSearchRelation = new TableDefinition(
            "WixSearchRelation",
            new[]
            {
                new ColumnDefinition("WixSearch_", ColumnType.String, 72, primaryKey: true, nullable: false, ColumnCategory.Identifier, keyTable: "WixSearch", keyColumn: 1, description: "Reference to a WixSearch entry in the WixSearch table."),
                new ColumnDefinition("ParentId_", ColumnType.String, 72, primaryKey: true, nullable: false, ColumnCategory.Identifier, keyTable: "WixSearch", keyColumn: 1, description: "Reference to a WixSearch entry in the WixSearch table."),
                new ColumnDefinition("Attributes", ColumnType.Number, 4, primaryKey: false, nullable: false, ColumnCategory.DoubleInteger),
            },
            unreal: true,
            tupleDefinitionName: TupleDefinitions.WixSearchRelation.Name,
            tupleIdIsPrimaryKey: true
        );

        public static readonly TableDefinition WixFileSearch = new TableDefinition(
            "WixFileSearch",
            new[]
            {
                new ColumnDefinition("WixSearch_", ColumnType.String, 72, primaryKey: true, nullable: false, ColumnCategory.Identifier, keyTable: "WixSearch", keyColumn: 1, description: "Reference to a WixSearch entry in the WixSearch table."),
                new ColumnDefinition("Path", ColumnType.String, 255, primaryKey: false, nullable: false, ColumnCategory.Text),
                new ColumnDefinition("MinVersion", ColumnType.String, 24, primaryKey: false, nullable: true, ColumnCategory.Version),
                new ColumnDefinition("MaxVersion", ColumnType.String, 24, primaryKey: false, nullable: true, ColumnCategory.Version),
                new ColumnDefinition("MinSize", ColumnType.Number, 4, primaryKey: false, nullable: true, ColumnCategory.DoubleInteger),
                new ColumnDefinition("MaxSize", ColumnType.Number, 4, primaryKey: false, nullable: true, ColumnCategory.DoubleInteger),
                new ColumnDefinition("MinDate", ColumnType.Number, 4, primaryKey: false, nullable: true, ColumnCategory.DoubleInteger),
                new ColumnDefinition("MaxDate", ColumnType.Number, 4, primaryKey: false, nullable: true, ColumnCategory.DoubleInteger),
                new ColumnDefinition("Languages", ColumnType.String, 0, primaryKey: false, nullable: true, ColumnCategory.Text),
                new ColumnDefinition("Attributes", ColumnType.Number, 4, primaryKey: false, nullable: false, ColumnCategory.DoubleInteger),
            },
            unreal: true,
            tupleDefinitionName: TupleDefinitions.WixFileSearch.Name,
            tupleIdIsPrimaryKey: true
        );

        public static readonly TableDefinition WixRegistrySearch = new TableDefinition(
            "WixRegistrySearch",
            new[]
            {
                new ColumnDefinition("WixSearch_", ColumnType.String, 72, primaryKey: true, nullable: false, ColumnCategory.Identifier, keyTable: "WixSearch", keyColumn: 1, description: "Reference to a WixSearch entry in the WixSearch table."),
                new ColumnDefinition("Root", ColumnType.Number, 2, primaryKey: false, nullable: false, ColumnCategory.DoubleInteger),
                new ColumnDefinition("Key", ColumnType.String, 255, primaryKey: false, nullable: false, ColumnCategory.Text),
                new ColumnDefinition("Value", ColumnType.String, 255, primaryKey: false, nullable: true, ColumnCategory.Text),
                new ColumnDefinition("Attributes", ColumnType.Number, 4, primaryKey: false, nullable: false, ColumnCategory.DoubleInteger),
            },
            unreal: true,
            tupleDefinitionName: TupleDefinitions.WixRegistrySearch.Name,
            tupleIdIsPrimaryKey: true
        );

        public static readonly TableDefinition WixComponentSearch = new TableDefinition(
            "WixComponentSearch",
            new[]
            {
                new ColumnDefinition("WixSearch_", ColumnType.String, 72, primaryKey: true, nullable: false, ColumnCategory.Identifier, keyTable: "WixSearch", keyColumn: 1, description: "Reference to a WixSearch entry in the WixSearch table."),
                new ColumnDefinition("Guid", ColumnType.String, 38, primaryKey: false, nullable: false, ColumnCategory.Guid),
                new ColumnDefinition("ProductCode", ColumnType.String, 38, primaryKey: false, nullable: true, ColumnCategory.Guid),
                new ColumnDefinition("Attributes", ColumnType.Number, 4, primaryKey: false, nullable: false, ColumnCategory.DoubleInteger),
            },
            unreal: true,
            tupleDefinitionName: TupleDefinitions.WixComponentSearch.Name,
            tupleIdIsPrimaryKey: true
        );

        public static readonly TableDefinition WixProductSearch = new TableDefinition(
            "WixProductSearch",
            new[]
            {
                new ColumnDefinition("WixSearch_", ColumnType.String, 72, primaryKey: true, nullable: false, ColumnCategory.Identifier, keyTable: "WixSearch", keyColumn: 1, description: "Reference to a WixSearch entry in the WixSearch table."),
                new ColumnDefinition("Guid", ColumnType.String, 38, primaryKey: false, nullable: false, ColumnCategory.Guid),
                new ColumnDefinition("Attributes", ColumnType.Number, 4, primaryKey: false, nullable: false, ColumnCategory.DoubleInteger),
            },
            unreal: true,
            tupleDefinitionName: TupleDefinitions.WixProductSearch.Name,
            tupleIdIsPrimaryKey: true
        );

        public static readonly TableDefinition[] All = new[]
        {
            ActionText,
            AdminExecuteSequence,
            Condition,
            AdminUISequence,
            AdvtExecuteSequence,
            AdvtUISequence,
            AppId,
            AppSearch,
            Property,
            BBControl,
            Billboard,
            Feature,
            Binary,
            BindImage,
            File,
            CCPSearch,
            CheckBox,
            Class,
            Component,
            Icon,
            ProgId,
            ComboBox,
            CompLocator,
            Complus,
            Directory,
            Control,
            Dialog,
            ControlCondition,
            ControlEvent,
            CreateFolder,
            CustomAction,
            DrLocator,
            DuplicateFile,
            Environment,
            Error,
            EventMapping,
            Extension,
            MIME,
            FeatureComponents,
            FileSFPCatalog,
            SFPCatalog,
            Font,
            IniFile,
            IniLocator,
            InstallExecuteSequence,
            InstallUISequence,
            IsolatedComponent,
            LaunchCondition,
            ListBox,
            ListView,
            LockPermissions,
            MsiLockPermissionsEx,
            Media,
            MoveFile,
            MsiAssembly,
            MsiAssemblyName,
            MsiDigitalCertificate,
            MsiDigitalSignature,
            MsiEmbeddedChainer,
            MsiEmbeddedUI,
            MsiFileHash,
            MsiPackageCertificate,
            MsiPatchCertificate,
            MsiPatchHeaders,
            PatchMetadata,
            MsiPatchMetadata,
            MsiPatchOldAssemblyFile,
            MsiPatchOldAssemblyName,
            PatchSequence,
            MsiPatchSequence,
            ODBCAttribute,
            ODBCDriver,
            ODBCDataSource,
            ODBCSourceAttribute,
            ODBCTranslator,
            Patch,
            PatchPackage,
            PublishComponent,
            RadioButton,
            Registry,
            RegLocator,
            RemoveFile,
            RemoveIniFile,
            RemoveRegistry,
            ReserveCost,
            SelfReg,
            ServiceControl,
            ServiceInstall,
            MsiServiceConfig,
            MsiServiceConfigFailureActions,
            Shortcut,
            MsiShortcutProperty,
            Signature,
            TextStyle,
            TypeLib,
            UIText,
            Upgrade,
            Verb,
            ModuleAdminExecuteSequence,
            ModuleAdminUISequence,
            ModuleAdvtExecuteSequence,
            ModuleAdvtUISequence,
            ModuleComponents,
            ModuleSignature,
            ModuleConfiguration,
            ModuleDependency,
            ModuleExclusion,
            ModuleIgnoreTable,
            ModuleInstallExecuteSequence,
            ModuleInstallUISequence,
            ModuleSubstitution,
            Properties,
            ImageFamilies,
            UpgradedImages,
            UpgradedFilesToIgnore,
            UpgradedFiles_OptionalData,
            TargetImages,
            TargetFiles_OptionalData,
            FamilyFileRanges,
            ExternalFiles,
            WixAction,
            WixBBControl,
            WixComplexReference,
            WixComponentGroup,
            WixControl,
            WixCustomRow,
            WixCustomTable,
            WixDirectory,
            WixEnsureTable,
            WixFeatureGroup,
            WixPatchFamilyGroup,
            WixGroup,
            WixFeatureModules,
            WixFile,
            WixBindUpdatedFiles,
            WixBuildInfo,
            WixFragment,
            WixInstanceComponent,
            WixInstanceTransforms,
            WixMedia,
            WixMediaTemplate,
            WixMerge,
            WixOrdering,
            WixDeltaPatchFile,
            WixDeltaPatchSymbolPaths,
            WixProperty,
            WixSimpleReference,
            WixSuppressAction,
            WixSuppressModularization,
            WixPatchBaseline,
            WixPatchRef,
            WixPatchId,
            WixPatchTarget,
            WixPatchMetadata,
            WixUI,
            WixVariable,
            WixBundleContainer,
            WixBundlePayloadGroup,
            WixBundlePayload,
            WixBundlePatchTargetCode,
            WixBundle,
            WixApprovedExeForElevation,
            WixBundleUpdate,
            WixBootstrapperApplication,
            WixUpdateRegistration,
            WixBundleCatalog,
            WixChain,
            WixChainItem,
            WixBundleRollbackBoundary,
            WixBundlePackageGroup,
            WixBundlePackage,
            WixBundleExePackage,
            WixBundleMsiPackage,
            WixBundleMspPackage,
            WixBundleMsuPackage,
            WixBundlePackageExitCode,
            WixBundleMsiFeature,
            WixBundleMsiProperty,
            WixBundleSlipstreamMsp,
            WixBundlePackageCommandLine,
            WixRelatedBundle,
            WixBundleRelatedPackage,
            WixBundleVariable,
            WixBundleProperties,
            WixPackageFeatureInfo,
            WixPackageProperties,
            WixPayloadProperties,
            Streams,
            SummaryInformation,
            TransformView,
            Validation,
            WixSearch,
            WixSearchRelation,
            WixFileSearch,
            WixRegistrySearch,
            WixComponentSearch,
            WixProductSearch,
        };
    }
}