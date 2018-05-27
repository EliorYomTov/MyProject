
// PaintProjectDlg.cpp : implementation file
//

#include "stdafx.h"
#include "PaintProject.h"
#include "PaintProjectDlg.h"
#include "afxdialogex.h"
#include "Shape.h"
#include "Line.h"
#include "Rectangle.h"
#include "Ellipse.h"
#include "Triangle.h"
#include <typeinfo>

#ifdef _DEBUG
#define new DEBUG_NEW
#endif

// CAboutDlg dialog used for App About

class CAboutDlg : public CDialogEx
{
public:
	CAboutDlg();

	// Dialog Data
	enum { IDD = IDD_ABOUTBOX };

protected:
	virtual void DoDataExchange(CDataExchange* pDX);    // DDX/DDV support

	// Implementation
protected:
	DECLARE_MESSAGE_MAP()
};

CAboutDlg::CAboutDlg() : CDialogEx(CAboutDlg::IDD)
{
}

void CAboutDlg::DoDataExchange(CDataExchange* pDX)
{
	CDialogEx::DoDataExchange(pDX);
}

BEGIN_MESSAGE_MAP(CAboutDlg, CDialogEx)
END_MESSAGE_MAP()

// CPaintProjectDlg dialog

CPaintProjectDlg::CPaintProjectDlg(CWnd* pParent /*=NULL*/)
	: CDialogEx(CPaintProjectDlg::IDD, pParent)
{
	m_hIcon = AfxGetApp()->LoadIcon(IDR_MAINFRAME);
}

void CPaintProjectDlg::DoDataExchange(CDataExchange* pDX)
{
	CDialogEx::DoDataExchange(pDX);
}

BEGIN_MESSAGE_MAP(CPaintProjectDlg, CDialogEx)
	ON_WM_SYSCOMMAND()
	ON_WM_PAINT()
	ON_WM_QUERYDRAGICON()
	ON_WM_MOUSEMOVE()
	ON_WM_LBUTTONDOWN()
	ON_WM_LBUTTONUP()
	ON_COMMAND(ID_FILE_NEW, &CPaintProjectDlg::OnFileNew)
	ON_COMMAND(ID_FILE_SAVE, &CPaintProjectDlg::OnFileSave)
	ON_COMMAND(ID_FILE_LOAD, &CPaintProjectDlg::OnFileLoad)
	ON_COMMAND(ID_ABOUT, &CPaintProjectDlg::OnAbout)
	ON_COMMAND(ID_FILE_EXIT, &CPaintProjectDlg::OnFileExit2)
	ON_BN_CLICKED(ID_BUTTONE,OnToolbarEllipse)
	ON_BN_CLICKED(ID_BUTTONR,OnToolbarRectangle)
	ON_BN_CLICKED(ID_BUTTONT,OnToolbarTriangle)
	ON_BN_CLICKED(ID_BUTTONL,OnToolbarLine)
	ON_BN_CLICKED(ID_BUTTONundo,OnToolbarUndo)
	ON_BN_CLICKED(ID_BUTTONredo,OnToolbarRedo)
	ON_BN_CLICKED(ID_BUTTONFillColor,OnToolbarFillColor)
	ON_BN_CLICKED(ID_BUTTONborderColor,OnToolbarBorderColor)
	ON_BN_CLICKED(ID_BUTTONsmall,OnToolbarSmall)
	ON_BN_CLICKED(ID_BUTTONmedium, OnToolbarMedium)
	ON_BN_CLICKED(ID_BUTTONlarge,OnToolbarLarge)
	ON_WM_RBUTTONDOWN()
	ON_WM_RBUTTONUP()
END_MESSAGE_MAP()

// CPaintProjectDlg message handlers

BOOL CPaintProjectDlg::OnInitDialog()
{
	isFound = false;
	isPress = false;
	isUserSelect = false;
	borderColor = RGB(0,0,0);
	fillColor = RGB(255,255,255);
	brushSize = 3;

	CDialogEx::OnInitDialog();

	// Create the Toolbar and attach the resource
	if(!m_wndToolBar.CreateEx(this, TBSTYLE_FLAT 
		,  CBRS_BORDER_BOTTOM | WS_CHILD | WS_VISIBLE | CBRS_TOP |  CBRS_TOOLTIPS | CBRS_FLYBY | CBRS_SIZE_DYNAMIC)
		|| !m_wndToolBar.LoadToolBar(IDR_TOOLBAR1))
	{
		TRACE0("Failed to Create Dialog Toolbar\n");
		EndDialog(IDCANCEL);
	}

	CRect	rcClientOld; // Old Client Rect
	CRect	rcClientNew; // New Client Rect with Tollbar Added
	GetClientRect(rcClientOld); 
	RepositionBars(AFX_IDW_CONTROLBAR_FIRST,AFX_IDW_CONTROLBAR_LAST,0,reposQuery,rcClientNew);
	RepositionBars(AFX_IDW_CONTROLBAR_FIRST,AFX_IDW_CONTROLBAR_LAST,0);

	CMenu menu;
	menu.LoadMenu(IDR_MENU1);
	SetMenu(&menu);

	ASSERT((IDM_ABOUTBOX & 0xFFF0) == IDM_ABOUTBOX);
	ASSERT(IDM_ABOUTBOX < 0xF000);

	CMenu* pSysMenu = GetSystemMenu(FALSE);
	if (pSysMenu != NULL)
	{
		BOOL bNameValid;
		CString strAboutMenu;
		bNameValid = strAboutMenu.LoadString(IDS_ABOUTBOX);
		ASSERT(bNameValid);
		if (!strAboutMenu.IsEmpty())
		{
			pSysMenu->AppendMenu(MF_SEPARATOR);
			pSysMenu->AppendMenu(MF_STRING, IDM_ABOUTBOX, strAboutMenu);
		}
	}

	// Set the icon for this dialog.  The framework does this automatically
	//  when the application's main window is not a dialog
	SetIcon(m_hIcon, TRUE);			// Set big icon
	SetIcon(m_hIcon, FALSE);		// Set small icon

	// TODO: Add extra initialization here

	return TRUE;  // return TRUE  unless you set the focus to a control
}

void CPaintProjectDlg::OnSysCommand(UINT nID, LPARAM lParam)
{
	if ((nID & 0xFFF0) == IDM_ABOUTBOX)
	{
		CAboutDlg dlgAbout;
		dlgAbout.DoModal();
	}
	else
	{
		CDialogEx::OnSysCommand(nID, lParam);
	}
}

// If you add a minimize button to your dialog, you will need the code below
//  to draw the icon.  For MFC applications using the document/view model,
//  this is automatically done for you by the framework.

void CPaintProjectDlg::OnPaint()
{
	CPaintDC dc(this);
	{
		CDialogEx::OnPaint();
		for (int i=0; i<shapeList.GetSize(); i++)
		{
			CPen pen(PS_SOLID,shapeList[i]->borderSize,shapeList[i]->borderColor);
			CBrush brush(shapeList[i]->fillColor);
			dc.SelectObject(&pen);
			dc.SelectObject(&brush);
			shapeList[i]->draw(&dc);
		}
	}
}

// The system calls this function to obtain the cursor to display while the user drags
//  the minimized window.
HCURSOR CPaintProjectDlg::OnQueryDragIcon()
{
	return static_cast<HCURSOR>(m_hIcon);
}

void CPaintProjectDlg::OnLButtonDown(UINT nFlags, CPoint point)
{
	if (isUserSelect)
	{
		isPress = true;
		s->setStart(point);
		s->setEnd(point);
		Invalidate();
	}
	CDialogEx::OnLButtonDown(nFlags, point);
}

void CPaintProjectDlg::OnMouseMove(UINT nFlags, CPoint point)
{
	CPen pen;
	CBrush brush;
	CClientDC dc(this);
	dc.SetROP2(R2_NOTXORPEN);
	if (isPress)
	{
		pen.CreatePen(PS_SOLID,brushSize,borderColor);
		brush.CreateSolidBrush(fillColor);
		dc.SelectObject(&pen);
		dc.SelectObject(&brush);
		s->draw(&dc);
		s->setEnd(point);
		s->draw(&dc);
	}
	else if (isFound)
	{
		int offSetx, offSety;
		pen.CreatePen(PS_SOLID,s->borderSize,s->borderColor);
		brush.CreateSolidBrush(s->fillColor);
		dc.SelectObject(&pen);
		dc.SelectObject(&brush);
		s->draw(&dc);
		start = end;
		end = point;
		offSetx = end.x-start.x;
		offSety = end.y-start.y;
		s->start.x += offSetx;
		s->start.y +=offSety;
		s->end.x +=offSetx;
		s->end.y +=offSety;
		s->draw(&dc);
	}
	CDialogEx::OnMouseMove(nFlags, point);
}

void CPaintProjectDlg::OnLButtonUp(UINT nFlags, CPoint point)
{
	if (isPress)
	{
		isPress = false;	
		Shape *temp;
		if (typeid(RectangleS) == typeid(*s)) temp = new RectangleS;
		else if (typeid(EllipseS) == typeid(*s)) temp = new EllipseS;
		else if (typeid(LineS) == typeid(*s)) temp = new LineS;
		else if (typeid(TriangleS) == typeid(*s)) temp = new TriangleS;
		s->borderColor =  borderColor;
		s->fillColor = fillColor;
		s->borderSize = brushSize;
		*temp = *s;
		shapeList.Add(temp);
		Invalidate();
	}
	CDialogEx::OnLButtonUp(nFlags, point);
}

void CPaintProjectDlg::OnFileNew()
{
	int i = shapeList.GetSize()-1;
	for (; i>=0 ; i--)
		delete shapeList[i];
	shapeList.RemoveAll();
	i = reDo.GetSize()-1;
	for (; i>=0 ; i--)
		delete reDo[i];
	reDo.RemoveAll();
	Invalidate();
	isFound = false;
	isPress = false;
	isUserSelect = false;
	borderColor = RGB(0,0,0);
	fillColor = RGB(255,255,255);
	brushSize = 3;
}

void CPaintProjectDlg::OnFileSave()
{
	CFile file(_T("File.$$"),CFile::modeCreate | CFile::modeWrite);
	CArchive ar (&file, CArchive::store);
	shapeList.Serialize(ar);
	ar.Close();
	file.Close();
}

void CPaintProjectDlg::OnFileLoad()
{
	CFile file(_T("File.$$"), CFile::modeRead);
	CArchive ar (&file, CArchive::load);
	shapeList.Serialize(ar);
	ar.Close();
	file.Close();
	Invalidate();
}

void CPaintProjectDlg::OnAbout()
{
	CAboutDlg().DoModal();
}

void CPaintProjectDlg::OnFileExit2()
{
	EndDialog(0);
}

void CPaintProjectDlg::OnToolbarEllipse()
{
	if (isUserSelect) delete s;
	isUserSelect = true;
	s = new EllipseS;
}

void CPaintProjectDlg::OnToolbarRectangle()
{
	if (isUserSelect) delete s;
	isUserSelect = true;
	s = new RectangleS;
}

void CPaintProjectDlg::OnToolbarTriangle()
{
	if (isUserSelect) delete s;
	isUserSelect = true;
	s = new TriangleS;
}

void CPaintProjectDlg::OnToolbarLine()
{
	if (isUserSelect) delete s;
	isUserSelect = true;
	s = new LineS;
}

void CPaintProjectDlg::OnToolbarUndo()
{
	int i= shapeList.GetSize()-1;
	if (! shapeList.IsEmpty())
	{
		reDo.Add(shapeList[i]);
		shapeList.RemoveAt(i);
		Invalidate();
	}
}

void CPaintProjectDlg::OnToolbarRedo()
{
	int i= reDo.GetSize()-1;
	if (!reDo.IsEmpty())
	{
		shapeList.Add(reDo[i]);
		reDo.RemoveAt(i);
		Invalidate();
	}
}

void CPaintProjectDlg::OnToolbarFillColor()
{
	CColorDialog dlg; 
	if (dlg.DoModal() == IDOK) 
	{ 
		fillColor = dlg.GetColor(); 
	}

}

void CPaintProjectDlg::OnToolbarBorderColor()
{
	CColorDialog dlg; 
	if (dlg.DoModal() == IDOK) 
	{ 
		borderColor = dlg.GetColor(); 
	}

}

void CPaintProjectDlg::OnToolbarSmall()
{
	brushSize = 2;
}

void CPaintProjectDlg::OnToolbarMedium()
{
	brushSize = 4;
}

void CPaintProjectDlg::OnToolbarLarge()
{
	brushSize = 8;
}

void CPaintProjectDlg::OnRButtonDown(UINT nFlags, CPoint point)
{
	int i = shapeList.GetSize()-1;
	start = end = point;
	while (i >= 0 && !isFound)
	{
		if(shapeList[i]->pointIsIn(point))
		{
			s = shapeList[i];
			shapeList.RemoveAt(i);
			isFound = true;
		}
		i--;
	}
	Invalidate();
	CDialogEx::OnRButtonDown(nFlags, point);
}

void CPaintProjectDlg::OnRButtonUp(UINT nFlags, CPoint point)
{
	if (isFound)
	{
		Shape *temp;
		if (typeid(RectangleS) == typeid(*s)) temp = new RectangleS;
		else if (typeid(EllipseS) == typeid(*s)) temp = new EllipseS;
		else if (typeid(LineS) == typeid(*s)) temp = new LineS;
		else if (typeid(TriangleS) == typeid(*s)) temp = new TriangleS;
		*temp = *s;
		shapeList.Add(temp);
		Invalidate();
		isFound = false;
	}
	CDialogEx::OnRButtonUp(nFlags, point);
}
