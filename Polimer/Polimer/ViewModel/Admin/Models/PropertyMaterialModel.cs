﻿namespace Polimer.App.ViewModel.Admin.Models;

public class PropertyMaterialModel : ViewModelBase, IModelAsEntity
{
    private int? _id;
    private PropertyModel _property;
    private MaterialModel _material;
    private double _value;

    public int? Id
    {
        get => _id;
        set => SetField(ref _id, value);
    }

    public PropertyModel Property
    {
        get => _property;
        set => SetField(ref _property, value);
    }

    public MaterialModel Material
    {
        get => _material;
        set => SetField(ref _material, value);
    }

    public double Value
    {
        get => _value;
        set => SetField(ref _value, value);
    }
}
