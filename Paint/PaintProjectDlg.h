
// PaintProjectDlg.h : header file
#include <vector>
#include "Shape.h"
#include"Line.h"
#include "Ellipse.h"
#include "Rectangle.h"
#include "Point.h"

using namespace std;
#pragma once


class CPaintProjectDlg : public CDialogEx
{
	CPoint start,end;
	CTypedPtrArray< CObArray, Shape*> shapeList, reDo;
	Shape *s;
	COLORREF borderColor, fillColor;
	CBrush myBrush;
	bool isPress, isUserSelect, isFound;
	int brushSize;
	CToolBar m_wndToolBar;

	// Construction
public:
	CPaintProjectDlg(CWnd* pParent = NULL);	// standard constructor

// Dialog Data
	enum { IDD = IDD_PAINTPROJECT_DIALOG };

	protected:
	virtual void DoDataExchange(CDataExchange* pDX);	// DDX/DDV support


// Implementation
protected:
	HICON m_hIcon;

	// Generated message map functions
	virtual BOOL OnInitDialog();
	afx_msg void OnSysCommand(UINT nID, LPARAM lParam);
	afx_msg void OnPaint();
	afx_msg HCURSOR OnQueryDragIcon();
	DECLARE_MESSAGE_MAP()
public:
	afx_msg void OnMouseMove(UINT nFlags, CPoint point);
	afx_msg void OnLButtonDown(UINT nFlags, CPoint point);
	afx_msg void OnLButtonUp(UINT nFlags, CPoint point);
	afx_msg void OnFileNew();
	afx_msg void OnFileSave();
	afx_msg void OnFileLoad();
	afx_msg void OnAbout();
	afx_msg void OnFileExit2();
	afx_msg void OnToolbarEllipse();
	afx_msg void OnToolbarRectangle();
	afx_msg void OnToolbarTriangle();
	afx_msg void OnToolbarLine();
	afx_msg void OnToolbarUndo();
	afx_msg void OnToolbarRedo();
	afx_msg void OnToolbarFillColor();
	afx_msg void OnToolbarBorderColor();
	afx_msg void OnToolbarSmall();
	afx_msg void OnToolbarMedium();
	afx_msg void OnToolbarLarge();
	afx_msg void OnRButtonDown(UINT nFlags, CPoint point);
	afx_msg void OnRButtonUp(UINT nFlags, CPoint point);
	afx_msg void OnAcceleratorz();
};
