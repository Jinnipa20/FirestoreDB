using MauiFirestoreAssignment.Services;
using MauiFirestoreAssignment.ViewModels;

namespace MauiFirestoreAssignment;

public partial class StudentPage : ContentPage
{
	public StudentPage()
	{
		InitializeComponent();
		var firestoreService = new FirestoreService();
		BindingContext = new StudentViewModel(firestoreService);
	}
}