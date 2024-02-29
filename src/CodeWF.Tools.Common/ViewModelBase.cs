﻿namespace CodeWF.Tools.Common;

//[AddINotifyPropertyChangedInterface]
public class ViewModelBase : BindableBase, INavigationAware, IActivatableViewModel, IDestructible
{
    //protected readonly IMediator Mediator;

    private string _title;

    public string Title
    {
        get => _title;
        set => SetProperty(ref _title, value);
    }


    public bool IsLoading => _isLoading.Value;
    private readonly ObservableAsPropertyHelper<bool> _isLoading;

    public ReactiveCommand<System.Reactive.Unit, System.Reactive.Unit> Login { get; set; }


    [Reactive] public string SearchText { get; set; }


    public ViewModelActivator Activator { get; } = new ViewModelActivator();

    //public ViewModelBase(IMediator mediator)
    //{
    //    Mediator = mediator;


    //    //_isLoading = this.WhenAnyObservable(x => x.Login.IsExecuting)
    //    //                   .ToProperty(this, x => x.IsLoading, initialValue: false);
    //}


    public bool IsNavigationTarget(NavigationContext navigationContext)
    {
        return OnNavigatingTo(navigationContext);
    }

    public virtual void OnNavigatedFrom(NavigationContext navigationContext)
    {
    }

    public virtual void OnNavigatedTo(NavigationContext navigationContext)
    {
    }

    public virtual bool OnNavigatingTo(NavigationContext navigationContext)
    {
        return true;
    }

    protected CompositeDisposable Disposal = new CompositeDisposable();

    public void Destroy()
    {
        Disposal.Dispose();
    }
}