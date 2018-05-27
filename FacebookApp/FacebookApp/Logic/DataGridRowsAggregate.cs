using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Drawing;
using System.Collections;
using FacebookWrapper.ObjectModel;

namespace FacebookApp.Logic
{
    public class DataGridRowsAggregate : IAggregate
    {
        private DataGridView m_PhotosDataGrid;

        public DataGridRowsAggregate(DataGridView i_PhotosDataGrid)
        {
            m_PhotosDataGrid = i_PhotosDataGrid;
        }

        public IIterator CreateIterator()
        {
            return new RowsDataGridIterator(m_PhotosDataGrid.Rows);
        }

        private class RowsDataGridIterator : IIterator
        {
            private DataGridViewRowCollection m_Collection;
            private int m_CurrentIdx = 0;
            private int m_Count = -1;

            public object CurrentItem
            {
                get { return m_Collection[m_CurrentIdx]; }
            }

            public bool IsDone
            {
                get { return m_CurrentIdx >= m_Collection.Count; }
            }

            public RowsDataGridIterator(DataGridViewRowCollection i_Collection)
            {
                m_Collection = i_Collection;
                m_Count = m_Collection.Count;
            }

            public void Reset()
            {
                m_CurrentIdx = 0;
            }

            public void Dispose()
            {
                Reset();
            }

            public bool Next()
            {
                return ++m_CurrentIdx < m_Collection.Count;
            }

            public IEnumerable<object> NextItem
            {
                get
                {
                    while (!IsDone)
                    {
                        yield return CurrentItem;
                        Next();
                    }
                }
            }
        }
    }
}