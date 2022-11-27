﻿using System.Threading.Tasks;
using System.Windows.Input;
using AutoMapper;
using Polimer.Data.Repository.Factory;

namespace Polimer.App.ViewModel.Admin;

public class AdminViewModel : ViewModelBase
{
    private UsersViewModel _usersVm;
    private MaterialsViewModel _materialsVm;
    private AdditiveViewModel _additiveVm;
    private CompatibilityMaterialViewModel _compatibilityVm;
    private MixtureViewModel _mixtureVm;
    private UnitViewModel _unitsVm;
    private PropertiesViewModel _propertiesVm;
    private PropertyMaterialViewModel _propertyMaterialVm;
    private PropertyMixtureViewModel _propertyMixtureVm;

    private AdminViewModel(
        IMapper mapper, 
        RepositoriesFactory repositoriesFactory
        )
    {
        _mixtureVm = MixtureViewModel
            .CreateInstance(repositoriesFactory.CreateMixtureRepository(), mapper);
        _usersVm = UsersViewModel
            .CreateInstance(repositoriesFactory.CreateUserRepository(), mapper);
        _materialsVm = MaterialsViewModel
            .CreateInstance(repositoriesFactory.CreateMaterialRepository(), mapper);
        _additiveVm = AdditiveViewModel
            .CreateInstance(repositoriesFactory.CreateAdditiveRepository(), mapper);
        _compatibilityVm = CompatibilityMaterialViewModel
            .CreateInstance(repositoriesFactory.CreateCompatibilityMaterialrRepository(),
                mapper,
                repositoriesFactory.CreateMaterialRepository());
        _unitsVm = UnitViewModel.CreateInstance(repositoriesFactory.CreateUnitRepository(), mapper);
        _propertiesVm = PropertiesViewModel
            .CreateInstance(
                repositoriesFactory.CreatePropertyRepository(), 
                mapper,
                repositoriesFactory.CreateUnitRepository());
        _propertyMaterialVm = PropertyMaterialViewModel.CreateInstance(
            repositoriesFactory.CreatePropertyMaterialRepository(), mapper,
            repositoriesFactory.CreateMaterialRepository(),
            repositoriesFactory.CreatePropertyRepository());
        
        _propertyMixtureVm = PropertyMixtureViewModel.CreateInstance(
            repositoriesFactory.CreatePropertyMixtureRepository(), mapper,
            repositoriesFactory.CreateMixtureRepository(),
            repositoriesFactory.CreatePropertyRepository());

        UpdateTablesCommand = new AsyncCommand(UpdateTablesAsync, () => true);
        UpdateTablesAsync();
    }

    internal static AdminViewModel CreateInstance(IMapper mapper,
        RepositoriesFactory repositoriesFactory)
    {
        return new AdminViewModel(mapper, repositoriesFactory);
    }

    public PropertyMixtureViewModel PropertyMixtureVM
    {
        get => _propertyMixtureVm;
        set => SetField(ref _propertyMixtureVm, value);
    }

    public PropertyMaterialViewModel PropertyMaterialVM
    {
        get => _propertyMaterialVm;
        set => SetField(ref _propertyMaterialVm, value);
    }

    public UnitViewModel UnitsVM
    {
        get => _unitsVm;
        set => SetField(ref _unitsVm, value);
    }

    public PropertiesViewModel PropertiesVM
    {
        get => _propertiesVm;
        set => SetField(ref _propertiesVm, value);
    }

    public MixtureViewModel MixtureVM
    {
        get => _mixtureVm;
        set => SetField(ref _mixtureVm, value);
    }

    public MaterialsViewModel MaterialsVM
    {
        get => _materialsVm;
        set => SetField(ref _materialsVm, value);
    }

    public AdditiveViewModel AdditiveVM
    {
        get => _additiveVm;
        set => SetField(ref _additiveVm, value);
    }

    public UsersViewModel UsersVM
    {
        get => _usersVm;
        set => SetField(ref _usersVm, value);
    }

    public CompatibilityMaterialViewModel CompatibilityVM
    {
        get => _compatibilityVm;
        set => SetField(ref _compatibilityVm, value);
    }

    public ICommand UpdateTablesCommand { get; set; }

    private async Task UpdateTablesAsync()
    {
        await UsersVM.UpdateEntitiesAsync();
        await MaterialsVM.UpdateEntitiesAsync();
        await AdditiveVM.UpdateEntitiesAsync();
        await CompatibilityVM.UpdateEntitiesAsync();
        await MixtureVM.UpdateEntitiesAsync();
        await UnitsVM.UpdateEntitiesAsync();
        await PropertiesVM.UpdateEntitiesAsync();
        await PropertyMaterialVM.UpdateEntitiesAsync();
        await PropertyMixtureVM.UpdateEntitiesAsync();
    }
}